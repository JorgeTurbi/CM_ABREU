using System.Reflection;
using System.Text;
using ApiCm.Commons.Connection;
using ApiCm.Commons.Settings;
using ApiCm.Data;
using ApiCm.Middleware;
using ApiCm.Repositories;
using ApiCm.Repositories.Interfaces;
using ApiCm.Services;
using ApiCm.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;
using Serilog;
using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);

// ----- SERILOG -----
var logFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "LogsApplication");

if (!Directory.Exists(logFolderPath))
    Directory.CreateDirectory(logFolderPath);

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File(Path.Combine(logFolderPath, "logs-.txt"), rollingInterval: RollingInterval.Day)
    .CreateLogger();

builder.Host.UseSerilog();

// ============= CORS =============
builder.Services.AddCors(options =>
{
    options.AddPolicy(
        "AllowAll",
        policy =>
        {
            policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
        }
    );
});

// ============= JWT SETTINGS =============
builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JwtSettings"));

// ============= SWAGGER (Swashbuckle) =============
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc(
        "v1",
        new OpenApiInfo
        {
            Title = "CM Abreu API",
            Version = "v1",
            Description = "Sistema CM Abreu API",
        }
    );

    c.SwaggerDoc("Auth", new OpenApiInfo { Title = "Auth", Version = "v1" });

    c.DocInclusionPredicate(
        (docName, apiDesc) =>
        {
            if (!apiDesc.TryGetMethodInfo(out var methodInfo))
                return false;

            var attrOnClass =
                methodInfo.DeclaringType?.GetCustomAttribute<ApiExplorerSettingsAttribute>();
            var attrOnMethod = methodInfo.GetCustomAttribute<ApiExplorerSettingsAttribute>();
            var groupName = attrOnMethod?.GroupName ?? attrOnClass?.GroupName;

            if (docName == "v1")
                return true;

            if (string.IsNullOrEmpty(groupName))
                return false;

            return string.Equals(groupName, docName, StringComparison.OrdinalIgnoreCase);
        }
    );

    c.AddSecurityDefinition(
        "Bearer",
        new OpenApiSecurityScheme
        {
            Type = SecuritySchemeType.Http,
            Scheme = "bearer",
            BearerFormat = "JWT",
            Description = "Ingrese su token JWT (sin el prefijo 'Bearer').",
        }
    );

    c.AddSecurityRequirement(doc =>
    {
        var schemeRef = new OpenApiSecuritySchemeReference("Bearer", doc);
        return new OpenApiSecurityRequirement { { schemeRef, new List<string>() } };
    });
});

// ============= JWT AUTHENTICATION =============
var jwtSettings = builder.Configuration.GetSection("JwtSettings");
var secretKey = jwtSettings["SecretKey"];

if (string.IsNullOrEmpty(secretKey))
{
    throw new InvalidOperationException("JWT SecretKey is not configured in appsettings.json");
}

builder
    .Services.AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(options =>
    {
        options.SaveToken = true;
        options.RequireHttpsMetadata = false;
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = jwtSettings.GetValue<bool>("ValidateIssuer"),
            ValidateAudience = jwtSettings.GetValue<bool>("ValidateAudience"),
            ValidateLifetime = jwtSettings.GetValue<bool>("ValidateLifetime"),
            ValidateIssuerSigningKey = jwtSettings.GetValue<bool>("ValidateIssuerSigningKey"),
            ValidIssuer = jwtSettings["Issuer"],
            ValidAudience = jwtSettings["Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),
            ClockSkew = TimeSpan.Zero,
            NameClaimType = System.Security.Claims.ClaimTypes.NameIdentifier,
        };

        options.Events = new JwtBearerEvents
        {
            OnAuthenticationFailed = context =>
            {
                Log.Warning("JWT authentication failed: {Exception}", context.Exception.Message);
                return Task.CompletedTask;
            },
        };
    });

// ============= MEMORY CACHE =============
builder.Services.AddMemoryCache();
builder.Services.AddHttpContextAccessor();

// ============= SERVICES (DI) =============
builder.Services.AddScoped<IPasswordHashService, PasswordHashService>();
builder.Services.AddScoped<IGeolocationService, GeolocationService>();
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IUserService, UserService>();

// ============= REPOSITORIES =============
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ISessionRepository, SessionRepository>();

builder.Services.AddAuthorization();

// ============= AUTOMAPPER =============
builder.Services.AddAutoMapper(typeof(Program));

// ============= FORWARDED HEADERS =============
builder.Services.Configure<ForwardedHeadersOptions>(options =>
{
    options.ForwardedHeaders =
        ForwardedHeaders.XForwardedFor
        | ForwardedHeaders.XForwardedProto
        | ForwardedHeaders.XForwardedHost;

    options.KnownIPNetworks.Clear();
    options.KnownProxies.Clear();
    options.ForwardLimit = null;
    options.RequireHeaderSymmetry = false;
});

// ============= DATABASE CONTEXT =============
var objetoConexion = new ConnectionApp();
var connectionStringConfig =
    $"Server={objetoConexion.Server};Database={objetoConexion.Database};User Id={objetoConexion.User};Password={objetoConexion.Password};TrustServerCertificate=True;";

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(connectionStringConfig);
});

var app = builder.Build();

app.UseCors("AllowAll");

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "CM Abreu API v1 (All)");
    c.SwaggerEndpoint("/swagger/Auth/swagger.json", "Auth");
    c.RoutePrefix = "swagger";
});

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseJwtSessionValidation();
app.UseAuthorization();
app.MapControllers();
app.Run();

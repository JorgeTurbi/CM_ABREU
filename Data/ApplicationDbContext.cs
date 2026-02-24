using ApiCm.Commons;
using ApiCm.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Session> Sessions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configuracion base para todas las entidades que heredan de BaseEntity
        foreach (
            var entity in modelBuilder
                .Model.GetEntityTypes()
                .Where(t => typeof(BaseEntity).IsAssignableFrom(t.ClrType))
        )
        {
            modelBuilder
                .Entity(entity.Name)
                .Property<DateTime>("CreatedAt")
                .HasDefaultValueSql("GETUTCDATE()")
                .ValueGeneratedOnAdd();

            modelBuilder.Entity(entity.Name).Property<DateTime?>("UpdatedAt");

            modelBuilder.Entity(entity.Name).Property<DateTime?>("DeletedAt");

            modelBuilder
                .Entity(entity.Name)
                .Property<bool>("IsDeleted")
                .HasDefaultValue(false)
                .IsRequired();
        }

        // Seed Data - Usuario administrador por defecto
        modelBuilder
            .Entity<User>()
            .HasData(
                new User
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Name = "Jhon",
                    LastName = "Doe",
                    Email = "dev@system.com",
                    UserName = "admin",
                    Password = "ujLrEhI8DophHcsOMCQQ+ghPJuvkKoEXYUjPmJYXqxBbrqirO6o6Vdph4a/cq5gd",
                    IsActive = true,
                }
            );

        // Tablas
        modelBuilder.Entity<User>().ToTable("Users");
        modelBuilder.Entity<Session>().ToTable("Sessions");

        // Indices unicos
        modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
        modelBuilder.Entity<User>().HasIndex(u => u.UserName).IsUnique();

        // Relacion User -> Sessions
        modelBuilder
            .Entity<Session>()
            .HasOne(s => s.User)
            .WithMany(u => u.Sessions)
            .HasForeignKey(s => s.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        // Configuracion de Session
        modelBuilder.Entity<Session>(entity =>
        {
            entity.Property(e => e.TokenRequest).IsRequired();
            entity.Property(e => e.TokenRefresh).HasMaxLength(64);
            entity.Property(e => e.IpAddress).HasMaxLength(45);
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.Device).HasMaxLength(500);
            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.Region).HasMaxLength(100);
            entity.Property(e => e.Latitude).HasMaxLength(50);
            entity.Property(e => e.Longitude).HasMaxLength(50);

            entity.HasIndex(e => e.TokenRefresh);
        });
    }
}

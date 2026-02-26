namespace ApiCm.Commons.Connection;

public class ConnectionApp
{
    public string Server { get; }
    public string User { get; }
    public string Password { get; }
    public string Database { get; set; }
    public string CmAbreuDatabase { get; set; }

    public ConnectionApp()
    {
        Server = Environment.GetEnvironmentVariable("DB_SERVER") ?? "localhost";
        User = Environment.GetEnvironmentVariable("DB_USER") ?? "sa";
        Password = Environment.GetEnvironmentVariable("DB_PASSWORD") ?? "Brittany040238.";
        Database = Environment.GetEnvironmentVariable("DB_DataBase") ?? "CMABREUDB";
        CmAbreuDatabase = Environment.GetEnvironmentVariable("DB_CmAbreu") ?? "CM_ABREU";
    }
}

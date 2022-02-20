namespace WebApp.StrategyPattern.Models
{
    public class Settings
    {
        public static string claimDatabaseType = "databaseType";
        public EDatabaseType DatabaseType;
        public EDatabaseType GetDefaultDatabaseType => EDatabaseType.SqlServer;
    }
}

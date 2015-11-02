namespace MusicSystem.Api
{
    using Data;
    using Data.Migrations;
    using System.Data.Entity;

    public class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MusicSystemDbContext, Configuration>());
            // Used to populate migrations
            MusicSystemDbContext.Create().Database.Initialize(true);
        }
    }
}
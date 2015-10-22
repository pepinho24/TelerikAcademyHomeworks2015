namespace Sample.ConsloeClient
{
    using Sample.Data;
    using Sample.Data.Migrations;
    using System.Data.Entity;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SampleDbContext, Configuration>());

            var db = new SampleDbContext();
            db.Samples.Count();
        }
    }
}

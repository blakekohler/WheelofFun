using System.Data.Entity.Migrations;

namespace WheelofFun.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<WheelofFun.EntityFramework.WheelofFunDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WheelofFun";
        }

        protected override void Seed(WheelofFun.EntityFramework.WheelofFunDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}

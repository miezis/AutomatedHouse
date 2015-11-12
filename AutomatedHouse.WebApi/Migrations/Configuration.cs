using AutomatedHouse.DataEntities.Entities;

namespace AutomatedHouse.WebApi.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AutomatedHouse.Data.AutomatedHouseDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AutomatedHouse.Data.AutomatedHouseDbContext context)
        {
            //This method will be called after migrating to the latest version.

            //You can use the DbSet<T>.AddOrUpdate() helper extension method
            //to avoid creating duplicate seed data.E.g.

              context.Houses.AddOrUpdate(
                new House { Name = "Manto House", ApiKey = "Random"},
                new House { Name = "Brice Lambson", ApiKey = "Random" },
                new House { Name = "Rowan Miller", ApiKey = "Random" }
              );

        }
    }
}

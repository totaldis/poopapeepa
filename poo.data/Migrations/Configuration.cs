namespace poo.data.Migrations
{
    using poo.domain;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<poo.data.PooContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(poo.data.PooContext context)
        {
            var researchers = new List<Researcher>
            {
                new Researcher{ Name = "Uncle Bo", Age = 32, ImageURL = "http://pickaface.net/avatar/DistantSecond52e82781af0d6.png" },
                new Researcher{ Name = "Madison", Age = 9 },
                new Researcher{ Name = "Reese", Age = 10 }
            };

            context.Researchers.AddOrUpdate(r=> r.Name, researchers.ToArray());
        }
    }
}

namespace poo.data.Migrations
{
    using poo.domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<poo.data.PooContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(poo.data.PooContext context)
        {
            #region Run me first
            context.Researchers.AddOrUpdate(
                r => r.Name,
                new Researcher { Name = "Uncle Bo", Age = 32, ImageURL = "http://pickaface.net/avatar/myspacedixson5247bbe83039a.png" },
                new Researcher { Name = "Reese", Age = 7, ImageURL = "http://pickaface.net/avatar/myspacedixson5247b99e8e893.png" },
                new Researcher { Name = "Madison", Age = 10, ImageURL = "http://pickaface.net/avatar/ralucahippie51e7038b35359.png" }
                );

            context.Labs.AddOrUpdate(
                l => l.Name,
                new Lab { Name = "Laboratory 1", City = "Boston", State = "Massachusetts", Country = "USA", PostalCode = "02110" },
                new Lab { Name = "Lavoratory II", City = "Cambridge", State = "Massachusetts", Country = "USA", PostalCode = "02138" },
                new Lab { Name = "Thomastory 3", City = "Prague", State = "NA", Country = "Russia", PostalCode = "28184730" }
                );
            #endregion

            #region Run me second

            context.Documents.AddOrUpdate(
                d => d.Name,
                new Document { LabId = 1, ResearcherId = 1, Name = "Document 1", TimeEffort = 1, Importance = Priority.VeryImportant, Description = "Wicked good document 1" },
                new Document { LabId = 2, ResearcherId = 2, Name = "Document ii", TimeEffort = 2, Importance = Priority.NotImportant, Description = "Wicked good document 2" },
                new Document { LabId = 3, ResearcherId = 3, Name = "Document 3", TimeEffort = 3, Importance = Priority.Important, Description = "Wicked good document 3" }
                );

            context.Photos.AddOrUpdate(
                d => d.Name,
                new Photo { LabId = 1, ResearcherId = 1, Name = "Photo 1", LocationDiscovered = "backyard", Importance = Priority.VeryImportant, Description = "Wicked good Photo 1" },
                new Photo { LabId = 2, ResearcherId = 2, Name = "Photo ii", LocationDiscovered = "frontyard", Importance = Priority.NotImportant, Description = "Wicked good Photo 2" },
                new Photo { LabId = 3, ResearcherId = 3, Name = "Photo 3", LocationDiscovered = "sideyard", Importance = Priority.Important, Description = "Wicked good Photo 3" }
                );
            #endregion
        }
    }
}

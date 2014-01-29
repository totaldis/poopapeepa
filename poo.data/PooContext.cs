using poo.domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.data
{
    public class PooContext : DbContext
    {
        public PooContext() : base("PooDb") { } // Set database name

        public DbSet<Document> Documents { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Lab> Labs { get; set; }
        public DbSet<Researcher> Researchers { get; set; }
        // public DbSet<Communication> Communications { get; set; } --- not yet

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}

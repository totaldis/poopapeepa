using poo.data;
using poo.data.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<PooContext>());
            
            GetResearchers();
        }

        private static void GetResearchers()
        {
            using (var context = new PooContext())
            {
                var researchers = context.Researchers.ToList();
                foreach (var r in researchers)
                {
                    Console.WriteLine(r.Name);
                    Console.ReadKey();
                }
            }
        }
    }
}

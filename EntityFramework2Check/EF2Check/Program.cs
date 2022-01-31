using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using EF2Check.models;
using Microsoft.EntityFrameworkCore.ChangeTracking;


namespace EF2Check
{
    class Program
    {
        public static Bieren_orgineelContext dbContext = new Bieren_orgineelContext();
        static void Main(string[] args)
        {
            
            //var bieren = dbContext.Bierens.ToList();
            //Console.WriteLine(bieren.Count);
           
            #region Check ET functionality
            Bier b = new Bier()
            {
                BierNr = 1000,
                BierNaam = "New b",
                BrouwerNr = null,
                SoortNr = null,
                Alchohol = 6.6f
            };

            //dbContext.Bierens.Add(b);

            //CheckEntityStatus(1000);
            //dbContext.SaveChanges();


            //var justInsertedBier = dbContext.Bieren.Find(b.BierNr = 1000);
            // PrintObject(justInsertedBier);

            //var bier2Upadte = dbContext.Bieren.Where(x => x.BierNr == 1000).FirstOrDefault();
            //PrintObject(bier2Upadte);

            //bier2Upadte.Naam = "Updated again bier";
            //var updatedBier = dbContext.Bierens.Where(x => x.BierNr == 1000).FirstOrDefault();
            //Console.WriteLine("+++++++++");
            //PrintObject(bier2Upadte);
            //CheckEntityStatus(1000);

            //dbContext.SaveChanges();

            //var bier2Remove = dbContext.Bieren.Find(1000);
           // PrintObject(bier2Remove);
           // dbContext.Remove(bier2Remove);
            //CheckEntityStatus(1000);

            //dbContext.SaveChanges();

            //Console.WriteLine("+++++++++++");
            //PrintObject(bier2Remove);
            #endregion

            SeedData();
        }

        public static void PrintObject(object obj)
        {
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(obj))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(obj);

                Console.WriteLine("{0}={1}", name, value);
            }
        }
        public static void CheckEntityStatus(int id)
        {
            Bier bier = dbContext.Bieren.Where(x => x.BierNr == id).FirstOrDefault();
            var entriesInContext = dbContext.ChangeTracker.Entries();

            foreach (var entry in entriesInContext)
            {
                Console.WriteLine($"Entity type: {entry.Entity.GetType().Name}");
                Console.WriteLine($"State: {entry.State}");
            }
        }

        public static void SeedData()
        {
            using var context = new Bieren_orgineelContext();
            context.Database.EnsureCreated();
            // seed
            if (!context.Personen.Any())
            {
                var personen = new List<Persoon>()
               {
                    new Persoon { Naam = "Bibi", FavouriteBierId1 = 1 },
                new Persoon { Naam = "Cici", FavouriteBierId1 = 11 },
                new Persoon { Naam = "didi", FavouriteBierId1 = 111 },
                new Persoon { Naam = "kiki", FavouriteBierId1 = 12 },
                new Persoon { Naam = "lili", FavouriteBierId1 = 14 },
                new Persoon { Naam = "mimi", FavouriteBierId1 = 61 }
               };
                context.Personen.AddRange(personen);
                context.SaveChanges();
                Console.WriteLine("Seeded");

            }
        }
    }
}

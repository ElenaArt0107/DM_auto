using SyntraWestCSharpTaak4EntityFrameworkOlenaArtiushenko.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SyntraWestCSharpTaak4EntityFrameworkOlenaArtiushenko
{
    class Program
    {
        static void Main(string[] args)
        {
            SeedData();
        }
        private static void SeedData()
        {
            using var context = new GezinContext();
            context.Database.EnsureCreated();
            //Seed

            if (!context.Straat.Any())
            {
                var straten = new List<Straat>()
                {
                    new Straat {Naam = "JaquesBrelStraat" }
                };
                context.Straat.AddRange(straten);
                context.SaveChanges();
                Console.WriteLine("Straat seeded");

            }

            if (!context.Huis.Any())
            {
                var huisen = new List<Huis>()
                {
                    new Huis { HuisNummer = "44B", StraatId = context.Straat.First().Id},
                    new Huis { HuisNummer = "12", StraatId = context.Straat.First().Id}
                };
                context.Huis.AddRange(huisen);
                context.SaveChanges();
                Console.WriteLine("huisen seeded");

            }

            if (!context.Persoon.Any())
            {
                var personen = new List<Persoon>()
                {
                    new Persoon { Voornaam = "Charles", Familienaam = "Aznavour", HuisId = 1 },
                    new Persoon { Voornaam = "Vicky", Familienaam = "Leandros", HuisId = 1 },
                    new Persoon { Voornaam = "Salvatore", Familienaam = "Adamo", HuisId = 2 }
                };
                context.Persoon.AddRange(personen);
                context.SaveChanges();
                Console.WriteLine("personen seeded");

            }

            if (!context.Hobby.Any())
            {
                var hobbies = new List<Hobby>()
                {
                    new Hobby { Naam = "Zingen" },
                    new Hobby { Naam = "Dansen" },
                    new Hobby { Naam = "Schrijven" },
                    new Hobby { Naam = "Diepzeeknikkeren" }
                };
                context.Hobby.AddRange(hobbies);
                context.SaveChanges();
                Console.WriteLine("hobbies seeded");

            }
            if (!context.HobbyPerPersoon.Any())
            {
                var hobbiesPerPersoon = new List<HobbyPerPersoon>()
                {
                    new HobbyPerPersoon { HobbyId = 1, PersoonId = 1 },
                    new HobbyPerPersoon { HobbyId = 1, PersoonId = 2 },
                    new HobbyPerPersoon { HobbyId = 1, PersoonId = 3 },
                    new HobbyPerPersoon { HobbyId = 2, PersoonId = 1 },
                    new HobbyPerPersoon { HobbyId = 2, PersoonId = 2 },
                    new HobbyPerPersoon { HobbyId = 3, PersoonId = 1 },
                    new HobbyPerPersoon { HobbyId = 4, PersoonId = 3 }
                };
                context.HobbyPerPersoon.AddRange(hobbiesPerPersoon);
                context.SaveChanges();
                Console.WriteLine("hobbiesPerPersoon seeded");

            }

        }
    }
}

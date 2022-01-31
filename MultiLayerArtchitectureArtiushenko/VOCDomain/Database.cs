using System;
using System.Collections.Generic;
using System.Text;

namespace VOCDomain
{
    public class Database
    {
        public Database()
        {
            CreateData();
        }
        public List<Persoon> Personen { get; set; } = new List<Persoon>();
        public List<Dier> Dieren { get; set; } = new List<Dier>();

        void CreateData()
        {
            Persoon p1 = new Persoon()
            {
                Voornaam = "Frencies",
                Familienaam = "Drake"
            };
            Persoon p2 = new Persoon()
            {
                Voornaam = "Chris",
                Familienaam = "Columbus"
            };
            Persoon p3 = new Persoon()
            {
                Voornaam = "Amerigo",
                Familienaam = "Vespucci"
            };
            Personen.Add(p1);
            Personen.Add(p2);
            Personen.Add(p3);

            Dier d1 = new Dier()
            {
                Volgnummer = 1,
                Soort = "shark",
                BinnengebrachtOp = DateTime.Now,
                BinnegebrachtDoor = p1
            };

            Dier d2 = new Dier()
            {
                Volgnummer = 2,
                Soort = "croco",
                BinnengebrachtOp = DateTime.Now,
                BinnegebrachtDoor = p1
            };
            Dier d3 = new Dier()
            {
                Volgnummer = 3,
                Soort = "seagul",
                BinnengebrachtOp = DateTime.Now,
                BinnegebrachtDoor = p2
            };
            Dier d4 = new Dier()
            {
                Volgnummer = 4,
                Soort = "emu",
                BinnengebrachtOp = DateTime.Now,
                BinnegebrachtDoor = p3
            };
            Dieren.Add(d1);
            Dieren.Add(d2);
            Dieren.Add(d3);
            Dieren.Add(d4);
            p1.DierenBinnenGebracht.Add(d1);
            p1.DierenBinnenGebracht.Add(d2);
            p2.DierenBinnenGebracht.Add(d3);
            p3.DierenBinnenGebracht.Add(d4);
        }
       

    }
}

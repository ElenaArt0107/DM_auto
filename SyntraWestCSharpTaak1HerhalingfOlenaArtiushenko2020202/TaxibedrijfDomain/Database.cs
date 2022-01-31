using System;
using System.Collections.Generic;
using System.Text;

namespace TaxibedrijfDomain
{
    public class Database
    {
        public List<Taxi> Taxis { get; set; } = new List<Taxi>();
        public List<Bestuurder> Bestuurders { get; set; } = new List<Bestuurder>();
        public Database()
        {
            CreateData();
        }

        void CreateData()
        {
            Bestuurder b1 = new Bestuurder()
            {
                Naam = "Nik",
                Familienaam = "Tesla",
            };

            Bestuurder b2 = new Bestuurder()
            {
                Naam = "Tom",
                Familienaam = "Edison",
                TaxiWagen = null,
            };

            Bestuurder b3 = new Bestuurder()
            {
                Naam = "Leo",
                Familienaam = "dai Vinchic",
                TaxiWagen = null,
            };

            Taxi t1 = new Taxi()
            {
                Nummerplaat = "SCY-1856",
                MaximumAantalPassagiers = 1,
                TaxiBestuurder = b1
            };
            Taxi t2 = new Taxi()
            {
                Nummerplaat = "USA-1847",
                MaximumAantalPassagiers = 2,
                TaxiBestuurder = null
            };
            Taxi t3 = new Taxi()
            {
                Nummerplaat = "ITA-1452",
                MaximumAantalPassagiers = 4,
                TaxiBestuurder = null
            };

            b1.TaxiWagen = t1;

            Taxis.Add(t1);
            Taxis.Add(t2);
            Taxis.Add(t3);

            Bestuurders.Add(b1);
            Bestuurders.Add(b2);
            Bestuurders.Add(b3);

        }
    }
}

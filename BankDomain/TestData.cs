using System;
using System.Collections.Generic;
using System.Text;

namespace BankDomain
{
    public class TestData
    {
        public TestData()
        {
            CreateData();
        }
        public List<Rekening> Rekeningen { get; set; } = new List<Rekening>();
        public List<Klant> Klanten { get; set; } = new List<Klant>();

        private void CreateData()
        {
            #region Types of accounts
            RekeningType zicht = new RekeningType
            {
                Id = 1,
                Naam = "Zicht"
            };
            RekeningType spaar = new RekeningType
            {
                Id = 2,
                Naam = "Spaar"
            };
            #endregion

            #region Klanten
            Klant troll = new Klant
            {
                Id = 1,
                Naam = "Troll",
                Adress = "Garden"
            };
            Klant drakeFrancis = new Klant
            {
                Id = 2,
                Naam = "Sir Francis Drake",
                Adress = "Pacific ocean"
            };
            Klant goblin = new Klant
            {
                Id = 3,
                Naam = "Goblin",
                Adress = "Gringotts Wizarding Bank"
            };

            Klanten.Add(troll);
            Klanten.Add(drakeFrancis);
            Klanten.Add(goblin);

            #endregion

            #region Rekeningen

            Rekening r1 = new Rekening
            {
                Id = 1,
                DateRekeningAangemaakt = DateTime.Now,
                HuidigeBalans = 0,
                Owner = troll,
                TypeRekening = zicht
            };
            troll.KlantRekeningen.Add(r1);

            Rekening r2 = new Rekening
            {
                Id = 2,
                DateRekeningAangemaakt = DateTime.Now,
                HuidigeBalans = 57000,
                Owner = drakeFrancis,
                TypeRekening = zicht
            };
            drakeFrancis.KlantRekeningen.Add(r2);

            Rekening r3 = new Rekening
            {
                Id = 3,
                DateRekeningAangemaakt = DateTime.Now,
                HuidigeBalans = 1265625,
                Owner = goblin,
                TypeRekening = spaar
            };
            Rekening r4 = new Rekening
            {
                Id = 4,
                DateRekeningAangemaakt = DateTime.Now,
                HuidigeBalans = 687,
                Owner = goblin,
                TypeRekening = zicht
            };

            goblin.KlantRekeningen.Add(r3);
            goblin.KlantRekeningen.Add(r4);


            Rekeningen.Add(r1);
            Rekeningen.Add(r2);
            Rekeningen.Add(r3);
            Rekeningen.Add(r4);
            #endregion
        }
    }
}

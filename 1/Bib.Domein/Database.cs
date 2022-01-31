using System;
using System.Collections.Generic;
using System.Text;

namespace Bib.Domein
{
    public class Database
    {
        public Database()
        {
            CreateData();
        }

        public List<Klant> Klanten = new List<Klant>();
        public List<Artikel> Artikelen = new List<Artikel>();
        public List<Ontlening> Ontleningen = new List<Ontlening>();

        void CreateData()
        {
            #region Klanten

            Klant k1 = new Klant
            {
                Id = 1,
                Voornaam = "Tweedle",
                Familienaam = "Dum"
            };

            Klant k2 = new Klant
            { Id = 2,
                Voornaam = "Tweedle",
                Familienaam = "Dee"
            };
            #endregion

            #region Artikelen
            Artikel a1 = new Artikel
            {
                Id = 1,
                Soort = "DVD",
                Titel = "Alice in the Wonderland"
            };

            Artikel a2 = new Artikel
            {
                Id = 2,
                Soort = "CD",
                Titel = "Alice Through the Looking-Glass"
            };

            #endregion


            #region Ontleninggen
            Ontlening o1 = new Ontlening()
            {
                Id = 1,
                DateOntlening = DateTime.Now,
                KlantOntlening = k1,
                ArtikelOntening = a1
            };
            Ontlening o2 = new Ontlening()
            {
                Id = 2,
                DateOntlening = DateTime.Now,
                KlantOntlening = k2,
                ArtikelOntening = a2
            };
            #endregion
            k1.Ontleningen.Add(o1);
            k2.Ontleningen.Add(o2);

            a1.Ontleningen.Add(o1);
            a2.Ontleningen.Add(o2);

            Artikelen.Add(a1);
            Artikelen.Add(a2);

            Klanten.Add(k1);
            Klanten.Add(k2);

            Ontleningen.Add(o1);
            Ontleningen.Add(o2);
        }
    }
   
}

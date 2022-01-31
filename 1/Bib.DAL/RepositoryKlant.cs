using Bib.Domein;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bib.DAL
{
    public class RepositoryKlant : IRepositoryKlant
    {
        private readonly Database _database;
        public RepositoryKlant(Database database)
        {
            _database = database;
        }
        public List<Klant> GetKlanten()
        {
            return _database.Klanten;
        }

        public Klant GetKlantByNaam(string voornaam, string familienaam)
        {
            foreach (var item in _database.Klanten)
            {
                if (voornaam == item.Voornaam && familienaam == item.Familienaam)
                {
                    return item;
                }
            }
            return null;
        }

        public void InsertKlant(Klant k)
        {
            _database.Klanten.Add(k);
        }
    }
}

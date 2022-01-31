using System;
using System.Collections.Generic;
using System.Text;
using Bib.Domein;

namespace Bib.DAL
{
    class RepositoryArtikel : IRepositoryArtikel
    {
        private readonly Database _database;
        public RepositoryArtikel(Database database)
        {
            _database = database;
        }
        public Artikel GetArtikelByVolgNumb(int artikelId)
        {
            foreach (var item in _database.Artikelen)
            {
                if (artikelId == item.Id)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Artikel> GetArtikels()
        {
            return _database.Artikelen;
        }

        public void UpdateArtikel(int artikelId, bool isOntleen)
        {
            Artikel a = GetArtikelByVolgNumb(artikelId);
            a.IsOntleend = isOntleen;
        }
    }
}

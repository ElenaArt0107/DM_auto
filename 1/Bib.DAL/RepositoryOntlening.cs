using Bib.Domein;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bib.DAL
{

    public class RepositoryOntlening : IRepositoryOntlening
    {
    private readonly Database _database;

        public RepositoryOntlening(Database database)
        {
            _database = database;
        }
        public Ontlening GetOntleningByVolnumb(int ontleningId)
        {
            foreach (var item in _database.Ontleningen)
            {
                if (ontleningId == item.Id)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Ontlening> GetOntleningen()
        {
            return _database.Ontleningen;
        }

        public void InsertOntlening(Artikel artikel, Klant klant)
        {
            Ontlening o = new Ontlening()
            {
                Id = GetVolgNummer(),
                KlantOntlening = klant,
                ArtikelOntening = artikel,
                DateOntlening = DateTime.Now
            };
            klant.Ontleningen.Add(o);
            artikel.Ontleningen.Add(o);
        }

        public void UpdateOntlening(int ontleningId)
        {
            throw new NotImplementedException();
        }

        int GetVolgNummer()
        {
            return _database.Ontleningen.Count;
        }
    }
}

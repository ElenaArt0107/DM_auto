using System;
using System.Collections.Generic;
using System.Text;
using VOCDomain;

namespace VOCDAL
{
    public class DierRepo
    {
        private readonly Database _database = new Database();

        public DierRepo(Database database)
        {
            _database = database;
        }
        public Dier GetDierByVolgnummer(int volgnummer)
        {
            foreach (Dier dier in _database.Dieren)
            {
                if (dier.Volgnummer == volgnummer)
                {
                    return dier;
                }
            }
            return null;
        }
        public List<Dier> GetDieren()
        {
            return _database.Dieren;
        }
        public void InsertDier(Dier dier)
        {
            _database.Dieren.Add(dier);
        }
        public void DeleteDier(int volgnummer)
        {
            Dier dier = GetDierByVolgnummer(volgnummer);
            _database.Dieren.Remove(dier);
        }
        public void UpdateDier(int volgnummer, Dier upgedateDier)
        {
            Dier dier = GetDierByVolgnummer(volgnummer);
            dier.Volgnummer = upgedateDier.Volgnummer;
        }

    }
}

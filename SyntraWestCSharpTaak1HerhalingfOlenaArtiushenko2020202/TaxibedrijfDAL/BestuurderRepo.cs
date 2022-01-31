using System;
using System.Collections.Generic;
using System.Text;
using TaxibedrijfDomain;

namespace TaxibedrijfDAL
{
    public class BestuurderRepo
    {
        Database _db = new Database();
        public BestuurderRepo(Database db)
        {
            _db = db;
        }

        public List<Bestuurder> GetAllBestuurders()
        {
           return _db.Bestuurders;
        }
        
        public Bestuurder GetBestuurder(string familiennaam)
        {
            foreach (Bestuurder bestuurder in _db.Bestuurders)
            {
                if (bestuurder.Familienaam == familiennaam)
                {
                    return bestuurder;
                }
            }
            return null;
        }

        public void BestuurderUpdate(Taxi gekozenWagen, Bestuurder gekozenBestuurder)
        {
            Bestuurder b = GetBestuurder(gekozenBestuurder.Familienaam);
            b.TaxiWagen = gekozenWagen;
        }
    }
}

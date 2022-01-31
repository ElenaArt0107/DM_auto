using System;
using System.Collections.Generic;
using System.Text;
using TaxibedrijfDomain;


namespace TaxibedrijfDAL
{
    public class TaxiRepo
    {
        Database _db = new Database();
        public TaxiRepo(Database db)
        {
            _db = db;
        }

        public List<Taxi> GetAllTaxis()
        {
            return _db.Taxis;
        }
        public Taxi GetTaxi(string nummerplaat)
        {
            foreach (Taxi taxi in _db.Taxis)
            {
                if (taxi.Nummerplaat == nummerplaat)
                {
                    return taxi;
                }
            }
            return null;
        }
        public void TaxiUpdate(Taxi gekozenWagen, Bestuurder gekozenBestuurder)
        {
            Taxi taxi2Change = GetTaxi(gekozenWagen.Nummerplaat);
            taxi2Change.TaxiBestuurder = gekozenBestuurder;
        }
    }
}

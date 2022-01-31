using System;
using System.Collections.Generic;
using System.Text;
using VOCDomain;


namespace VOCDAL
{
    public class PersonRepo
    {
        //CRUD 
        //создание (англ. create), чтение (read), модификация (update), удаление (delete)
        private readonly Database _db = new Database();

        public PersonRepo(Database db)
        {
            _db = db;
        }

        public Persoon GetPersoonByVoornaam(string voornaam)
        {
            foreach (Persoon persoon in _db.Personen)
            {
                if (persoon.Voornaam == voornaam)
                {
                    return persoon;
                }
            }
            return null;
        }
        public List<Persoon> GetPersonen()
        {
            return _db.Personen;
        }
         
        public void InsertPersoon(Persoon persoon)
        {
            _db.Personen.Add(persoon);
        }
        public void DeletePersoon(Persoon persoon)
        {
            _db.Personen.Remove(persoon);
        }
        public void UpdatePersoon(string voornaam, Persoon persoonMetUpgatedeEigenschappen)
        {
            Persoon p = GetPersoonByVoornaam(voornaam);

            p.Voornaam = persoonMetUpgatedeEigenschappen.Voornaam;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using BankDomain;

namespace BankDAL
{
    // DAL = Data Analysis Layer
    public class KlantRepository
    {
        TestData _database;
        public KlantRepository(TestData database)
        {
            _database = database;
        }
        public void MaakKlantAan(string naam, string adres)
        {
            Klant neuuweKlant = new Klant
            {
                Naam = naam,
                Adress = adres,
                Id = _database.Klanten.Count + 1
            };
            _database.Klanten.Add(neuuweKlant);
            Console.WriteLine($"The new customer - {neuuweKlant.Naam} = has been succesfully added.");
        }
        public Klant HaalKlantOpMetId(int id)
        {
            foreach (Klant klant in _database.Klanten)
            {
                if (klant.Id == id)
                {
                    return klant;
                }
            }
            return null;
        }
        public List<Klant> HaalKlantenOp()
            {
                return _database.Klanten;
            }
        public void VerwijderKlant(int id)
        {
            Klant klant = HaalKlantOpMetId(id);
            _database.Klanten.Remove(klant);
            Console.WriteLine($"The customer {klant.Id} {klant.Naam} has been succesfully removed");
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;
using BankDomain;


namespace BankDAL
{
    public class RekeningRepository
    {

        TestData _database;
        public RekeningRepository(TestData database)
        {
            _database = database;
        }
        public void MaakRekening(RekeningType type, DateTime aangemaaktOp, decimal balans, Klant owner)
        {
            Rekening neueweRekening = new Rekening
            {
                TypeRekening = type,
                DateRekeningAangemaakt = aangemaaktOp,
                HuidigeBalans = balans,
                Id = _database.Rekeningen.Count + 1,
                Owner = owner
            };
            _database.Rekeningen.Add(neueweRekening);
            Console.WriteLine($"The new account number {neueweRekening.Id} = has been succesfully added.");

        }
        public Rekening HaalRekeningOpMetId(int id)
        {
            foreach (Rekening rekening in _database.Rekeningen)
            {
                if (rekening.Id==id)
                {
                    return rekening;
                }
            }
            return null;
        }
        public List <Rekening> HaalRekeningenOp()
        {
            return _database.Rekeningen;

        }
        public void VerwijderRekening(int id)
        {
            Rekening rekening = HaalRekeningOpMetId(id);
            _database.Rekeningen.Remove(rekening);
            Console.WriteLine($"The account with id number {id} does not exist");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using BankDAL;
using BankDomain;

// Business layer
namespace BankServices
{
    public class KlantService
    {
   
        KlantRepository _klantRepository;
        RekeningRepository _rekeningRepository;

        public KlantService(KlantRepository klantRepository, RekeningRepository rekeningRepository)
        {
            _klantRepository = klantRepository;
            _rekeningRepository = rekeningRepository;
        }

        public void ToonKlant(Klant klant)
        {
            Klant k = _klantRepository.HaalKlantOpMetId(klant.Id);
            Console.WriteLine($"Customer info:\n---------------\nID: {k.Id}\nNaam: {k.Naam}\nAdress: {k.Adress}\n");
            Console.WriteLine("\tAccount info:");
            foreach (Rekening rekening in k.KlantRekeningen)
            {
                Console.WriteLine($"\n\t---------------\n\tID: {rekening.Id}\n\tDate: {rekening.DateRekeningAangemaakt}\n\tBalans: {rekening.HuidigeBalans}\n");
            }
            Console.WriteLine("* * * * * * * * * * * * * *\n\n");
        }

        public void ToonKlanten()
        {
            List<Klant> klanten = _klantRepository.HaalKlantenOp();
            foreach (Klant klant in klanten)
            {
                ToonKlant(klant);
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TaxibedrijfDAL;
using TaxibedrijfDomain;

namespace TaxibedrijfService
{
    public class TaxiService
    {
        private readonly TaxiRepo _taxiRepo;
        

        public TaxiService(TaxiRepo taxiRepo)
        {
            _taxiRepo = taxiRepo;
        }

        public void ToonAlleAutos()
        {

            Console.WriteLine("----------------");
            Console.WriteLine("Alle wagens: ");
            Console.WriteLine("----------------");

            foreach (Taxi t in _taxiRepo.GetAllTaxis())
            {
                ToonAuto(t);
                Console.WriteLine();
            }
        }

        public void ToonAutosZonderBestuurder()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Alle Autos Zonder Bestuurder: ");
            Console.WriteLine("-----------------------------");
            foreach (Taxi t in _taxiRepo.GetAllTaxis())
            {
                if (t.TaxiBestuurder == null)
                {
                    ToonAuto(t);
                    Console.WriteLine();
                }
            }
        }

        public void ToonAuto(Taxi t)
        {
            Console.WriteLine($"Nummerplaat: {t.Nummerplaat}");
            Console.WriteLine($"Maximum Aantal Passagieren: {t.MaximumAantalPassagiers}");
            Console.Write($"Volledige bestuurder:");
            if (t.TaxiBestuurder != null)
            {
                Console.Write($"{t.TaxiBestuurder.Naam} {t.TaxiBestuurder.Familienaam}");
            }
            else
            {
                Console.Write($" /");
            }
            Console.WriteLine();
        }

        public void ToonMenuVanBeschibarAutos()
        {
            int i = 1;
            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Kies een Beschikbaar Auto");
            Console.WriteLine("-------------------------");

            foreach (Taxi taxi in _taxiRepo.GetAllTaxis())
            {
                
                if (taxi.TaxiBestuurder == null)
                {
                    Console.Write($"{i++}) ");
                    ToonAuto(taxi);
                    Console.WriteLine();
                }
            }
            
        }
        // how to put it onto Repo and navigate in Console via Service???

        public List<Taxi> GetAllTaxisZonderBestuurder()
        {
            List<Taxi> taxis = new List<Taxi>();
            foreach (Taxi taxi in _taxiRepo.GetAllTaxis())
            {

                if (taxi.TaxiBestuurder == null)
                {
                    taxis.Add(taxi);
                }
            }
            return taxis;
        }


    }
}

using System;
using System.Collections.Generic;
using TaxibedrijfDAL;
using TaxibedrijfDomain;

namespace TaxibedrijfService
{
    public class BestuurderService
    {
        private readonly BestuurderRepo _bestuurderRepo;
        private readonly TaxiRepo _taxiRepo;

        public BestuurderService(BestuurderRepo bestuurderRepo, TaxiRepo taxiRepo)
        {
            _bestuurderRepo = bestuurderRepo;
            _taxiRepo = taxiRepo;
        }

        public void ToonBestuurder(Bestuurder b)
        {
            Console.WriteLine($"Naam: {b.Naam} {b.Familienaam}");
            Console.Write($"Auto: ");
            if (b.TaxiWagen == null)
            {
                Console.Write("/");
            }
            else
            {
                Console.Write ( $"Nummerplaat{ b.TaxiWagen.Nummerplaat} | Maximum Aantal Passagieren: {b.TaxiWagen.MaximumAantalPassagiers}");
            }
            Console.WriteLine();
        }

        public void ToonAlleBestuurders()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Alle Bestuurders: ");
            Console.WriteLine("----------------");

            foreach (Bestuurder bestuurder in _bestuurderRepo.GetAllBestuurders())
            {
                ToonBestuurder(bestuurder);
                Console.WriteLine();
            }
        }

        public void ToonBestuurdersZonderAuto()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Bestuurders zonder auto: ");
            Console.WriteLine("-----------------------------");

            foreach (Bestuurder bestuurder in _bestuurderRepo.GetAllBestuurders())
            {
                if (bestuurder.TaxiWagen == null)
                {
                    ToonBestuurder(bestuurder);
                    Console.WriteLine();
                }
            }
        }

        public void ToonMenuVanBeschibarBestuurders()
        {
            int i = 1;
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Kies een Beschikbaar Bestuurder");
            Console.WriteLine("-------------------------------");

            foreach (Bestuurder bestuurder in _bestuurderRepo.GetAllBestuurders())
            {

                if (bestuurder.TaxiWagen == null)
                {
                    Console.Write($"{i++}) ");
                    ToonBestuurder(bestuurder);
                    Console.WriteLine();
                }
            }
        }

        // how to put it onto Repo and navigate in Console via Service???
        public List<Bestuurder> GetBestuurdersZonderTaxi()
        {
            List<Bestuurder> bestuurders = new List<Bestuurder>();
            foreach (Bestuurder bestuurder in _bestuurderRepo.GetAllBestuurders())
            {

                if (bestuurder.TaxiWagen == null)
                {
                    bestuurders.Add(bestuurder);
                }
            }
            return bestuurders;
        }

        public void TaxiToewijzen (Taxi gekozenWagen, Bestuurder gekozenBestuurder)
        {
            _bestuurderRepo.BestuurderUpdate(gekozenWagen, gekozenBestuurder);
            _taxiRepo.TaxiUpdate(gekozenWagen, gekozenBestuurder);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Wagen nummer {gekozenWagen.Nummerplaat} is naar {gekozenBestuurder.Naam} {gekozenBestuurder.Familienaam} toegewezen");
            Console.ResetColor();
            Console.WriteLine();
            
        }

    }
}

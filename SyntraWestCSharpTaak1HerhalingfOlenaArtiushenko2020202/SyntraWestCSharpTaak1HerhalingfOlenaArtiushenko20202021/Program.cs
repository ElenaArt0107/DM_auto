using System;
using System.Collections.Generic;
using TaxibedrijfDAL;
using TaxibedrijfDomain;
using TaxibedrijfService;

namespace SyntraWestCSharpTaak1HerhalingfOlenaArtiushenko20202021
{
    class Program
    {
        private static TaxiService _taxibedrijfService;
        private static BestuurderService _bestuurderService;

        static void Setup()
        {
            Database database = new Database();
            TaxiRepo taxiRepo = new TaxiRepo(database);
            BestuurderRepo bestuurderRepo = new BestuurderRepo(database);
            _taxibedrijfService = new TaxiService(taxiRepo);
            _bestuurderService = new BestuurderService(bestuurderRepo, taxiRepo);
        }
        static void Main(string[] args)
        {
            Setup();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("===========================");
            Console.WriteLine("Welcome to the Taxibedrijf!");
            Console.WriteLine("===========================");
            Console.ResetColor();
            int choiceMenu;
            do
            {
                ToonMenu();
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    ToonFout();
                    choice = -1;
                }
                choiceMenu = choice;

                while (choiceMenu > 5 || choiceMenu < 0)
                {
                    ChoiseFailed(5);
                    if (!int.TryParse(Console.ReadLine(), out int ch))
                    {
                        ToonFout();
                        ch = -1;
                    }
                    choiceMenu = ch;
                }
                switch (choiceMenu)
                {
                    case 1:
                        _taxibedrijfService.ToonAlleAutos();
                        break;
                    case 2:
                        _bestuurderService.ToonAlleBestuurders();
                        break;
                    case 3:
                        _taxibedrijfService.ToonAutosZonderBestuurder();
                        break;
                    case 4:
                        _bestuurderService.ToonBestuurdersZonderAuto();
                        break;
                    case 5:
                        ToonMenuVoorToewijzen();
                        break;
                    case 0:
                        break;
                        // why the program breaks after ToonMenuVoorToewijzen() if the  choiceMenu is still 5?
                }
            } while (choiceMenu < 5 && choiceMenu > 0);

            void ToonMenu()
            {
                Console.WriteLine();
                Console.WriteLine("---------------");
                Console.WriteLine("Kies een optie:");
                Console.WriteLine("---------------");
                Console.WriteLine("1) Toon lijst van alle auto's");
                Console.WriteLine("2) Toon lijst van alle bestuurder");
                Console.WriteLine("3) Toon lijst van auto's zonder bestuurder");
                Console.WriteLine("4) Toon lijst van bestuurder zonder auto");
                Console.WriteLine("5) Hang een auto een bestuurder");
                Console.WriteLine("0) Stop programma");
                Console.WriteLine();
            }



            void ToonMenuVoorToewijzen()
            {
                Taxi gekozenWagen;
                Bestuurder gekozenBestuurder;

                _taxibedrijfService.ToonMenuVanBeschibarAutos();
                int choice1;

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    ToonFout();
                    choice = -1;
                }
                choice1 = choice;
                while (choice1 > _taxibedrijfService.GetAllTaxisZonderBestuurder().Count || choice1 < 0)
                {
                    ChoiseFailed(_taxibedrijfService.GetAllTaxisZonderBestuurder().Count);
                    if (!int.TryParse(Console.ReadLine(), out int ch))
                    {
                        ToonFout();
                        ch = -1;
                    }
                    choice1 = ch;
                }

                int index = choice1 - 1;
                gekozenWagen = _taxibedrijfService.GetAllTaxisZonderBestuurder()[index];

                _bestuurderService.ToonMenuVanBeschibarBestuurders();

                int choice2;
                if (!int.TryParse(Console.ReadLine(), out int choic))
                {
                    ToonFout();
                    choic = -1;
                }
                choice2 = choic;


                while (choice2 > _bestuurderService.GetBestuurdersZonderTaxi().Count || choice2 < 0)
                {
                    ChoiseFailed(_bestuurderService.GetBestuurdersZonderTaxi().Count);
                    if (!int.TryParse(Console.ReadLine(), out int ch))
                    {
                        ToonFout();
                        ch = -1;
                    }
                    choice2 = ch;
                }
                int index2 = choice2 - 1;
                gekozenBestuurder = _bestuurderService.GetBestuurdersZonderTaxi()[index2];

                _bestuurderService.TaxiToewijzen(gekozenWagen, gekozenBestuurder);

                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("Check the difference:");
                Console.ResetColor();
                Console.WriteLine();
                _bestuurderService.ToonAlleBestuurders();
            }

            void ChoiseFailed(int maxNummer)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Getal moet tussen 1 en {maxNummer} liggen");
                Console.ResetColor();
            }
            void ToonFout()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Geef een cijfen aub");
                Console.ResetColor();
            }

        }
    }
}

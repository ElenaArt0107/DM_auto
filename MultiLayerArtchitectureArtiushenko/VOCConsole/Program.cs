using System;
using System.Collections.Generic;
using VOCDAL;
using VOCDomain;
using VOCService;


namespace VOCConsole
{
    class Program
    {
        private static PersoonService _persoonService;
        private static DierService _dierService;
        static void Setup()
        {
            Database db = new Database();
            DierRepo dierRepo = new DierRepo(db);
            PersonRepo personRepo = new PersonRepo(db);
            _persoonService = new PersoonService(personRepo);
            _dierService = new DierService(dierRepo, personRepo);
        }
        static void Main(string[] args)
        {
            Setup();
            Console.WriteLine("Welcome to VOC!\n");
            _dierService.BrengDierBinnen("El", "Art", "LikeTao");
            Console.WriteLine("----------------------\nDieren alijn:\n---------------------- ");
            _dierService.ToonLijstVanDierenConsole();
            Console.WriteLine("----------------------\nMensen:\n---------------------- ");
            _persoonService.ToonLijstVanPersonenConsole();


        }
    }
}

using System;
using BankDAL;
using BankDomain;
using BankServices;
using System.Collections.Generic;

namespace BankConsole
{
    class Program
    {
        private static RekeningService _rekeningService;
        private static KlantService _klantService;

        static void Setup()
        {
            TestData db = new TestData();
            RekeningRepository rekeningRepository = new RekeningRepository(db);
            KlantRepository klantRepository = new KlantRepository(db);
            _rekeningService = new RekeningService(klantRepository, rekeningRepository);
            _klantService = new KlantService(klantRepository, rekeningRepository);
        }
        static void Main(string[] args)
        {
            Setup();
            // from here only the Services could be used:
            
            RekeningType typeRekening = new RekeningType();

            _rekeningService.MaakRekeningAan("El", "Bruges", typeRekening);

            _rekeningService.PlaatsBedragOpRekening(1, 543);

            _klantService.ToonKlanten();


        }
    }
}

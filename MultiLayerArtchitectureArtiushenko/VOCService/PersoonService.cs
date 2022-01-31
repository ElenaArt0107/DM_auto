using System;
using System.Collections.Generic;
using System.Text;
using VOCDAL;
using VOCDomain;

namespace VOCService
{
    public class PersoonService
    {
        private readonly PersonRepo _personRepo;
        public PersoonService(PersonRepo personRepo)
        {
            _personRepo = personRepo;
        }

        public void ToonLijstVanPersonenConsole()
        {
            foreach (Persoon persoon in _personRepo.GetPersonen())
            {
                ToonPersoon(persoon);
            }
        }

        public void ToonPersoon(Persoon persoon)
        {
            Console.WriteLine($"Full name: {persoon.Voornaam} {persoon.Familienaam}");

            foreach (Dier dier in persoon.DierenBinnenGebracht)
            {
                Console.WriteLine(dier.Volgnummer + " " + dier.Soort);
                Console.WriteLine("On the " + dier.BinnengebrachtOp + " was taken to VOC");
            }
            Console.WriteLine("* * * * * * * * * * * * ");
        }
    }
}

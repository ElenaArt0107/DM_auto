using System;
using System.Collections.Generic;
using System.Text;
using VOCDomain;
using VOCDAL;

namespace VOCService
{
    public class DierService
    {
        private readonly DierRepo _dierRepo;
        private readonly PersonRepo _personRepo;

        public DierService(DierRepo dierRepo, PersonRepo personRepo)
        {
            _dierRepo = dierRepo;
            _personRepo = personRepo;
        }
        public void ToonLijstVanDierenConsole()
        {
            foreach (Dier dier in _dierRepo.GetDieren())
            {
                Console.WriteLine(dier.Volgnummer + " " + dier.Soort);
                Console.WriteLine("On the "+dier.BinnengebrachtOp + " was taken to VOC by" + dier.BinnegebrachtDoor);
            }
        }
        public void BrengDierBinnen(string voornaam, string familienaam, string diersoort)
        {
            Persoon persoon = _personRepo.GetPersoonByVoornaam(voornaam);

            if (persoon == null)
            {
                persoon = new Persoon()
                {
                    Voornaam = voornaam,
                    Familienaam = familienaam
                };
                _personRepo.InsertPersoon(persoon);
            }

            int volgnummer = BiggestNumber();

            Dier dier = new Dier()
            {
                Soort = diersoort,
                BinnengebrachtOp = DateTime.Now,
                BinnegebrachtDoor = persoon,
                Volgnummer = volgnummer
            };
            _dierRepo.InsertDier(dier);
            persoon.DierenBinnenGebracht.Add(dier);
        }

        int BiggestNumber()
        {
            int volgnummer = 0;
            foreach (Dier d in _dierRepo.GetDieren())
            {
                if (d.Volgnummer> volgnummer)
                {
                    volgnummer = d.Volgnummer;
                }
            }
            return volgnummer+1;
        }



    }
}

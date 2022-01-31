using System;
using System.Collections.Generic;
using System.Text;
using BankDAL;
using BankDomain;

// Business layer
namespace BankServices
{
    public class RekeningService
    {
        KlantRepository _klantRepository;
        RekeningRepository _rekeningRepository;

        public RekeningService(KlantRepository klantRepository, RekeningRepository rekeningRepository)
        {
            _klantRepository = klantRepository;
            _rekeningRepository = rekeningRepository;
        }

        //MaakRekeningAan(string klantNaam, string adres, typeRekening)
        public void MaakRekeningAan(string klantNaam, string adres, RekeningType typeRekening)
        {
            Klant k = null;
            //        o Als klant nog niet bestaat maak deze aan
            List<Klant> klanten = new List<Klant>();
                klanten = _klantRepository.HaalKlantenOp();

            foreach (Klant klant in klanten)
            {
                if (klant.Naam != klantNaam || klant.Adress != adres)
                {
                    _klantRepository.MaakKlantAan(klantNaam, adres);
                    k = klant;
                }
                k = klant;
            }

            //      o   Maak rekening aan

             _rekeningRepository.MaakRekening(typeRekening, DateTime.Now, 000, k);
            
            //      o   Koppel klant aan der rekening en visa versa
            Rekening r = _rekeningRepository.HaalRekeningOpMetId(_rekeningRepository.HaalRekeningenOp().Count);
            k.KlantRekeningen.Add(r);

        }

        public void PlaatsBalanceOpRekening(int rekeningId, decimal balance)
        { 
            //•	PlaatsBedragOpRekening(int rekeningId, decimal bedrag)
            _rekeningRepository.HaalRekeningOpMetId(rekeningId).HuidigeBalans = balance;
        }


    }
}

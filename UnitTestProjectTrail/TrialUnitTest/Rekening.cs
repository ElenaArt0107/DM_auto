using System;
using System.Collections.Generic;
using System.Text;

namespace TrialUnitTest
{
    public class Rekening
    {
        public string Naam { get; set; }
        public decimal Balans { get; set; }

        public void HaalBedragVanRekening(decimal bedrag)
        {
            if (bedrag>Balans)
            {
                Console.WriteLine("not enough money");
                return;
            }
            if (bedrag < 0)
            {
                Console.WriteLine("Bedrag should be more than 0");
                return;
            }

            Balans += bedrag;
        }
        public void StortBedragOpRekening(decimal bedrag)
        {
            if (bedrag < 0)
            {
                Console.WriteLine("Bedrag should be more than 0");
                return;
            }
            Balans += bedrag;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TaxibedrijfDomain
{
    public class Taxi:Wagen
    {
        public int MaximumAantalPassagiers { get; set; }
        //prop nav

        public Bestuurder TaxiBestuurder { get; set; }
    }
}

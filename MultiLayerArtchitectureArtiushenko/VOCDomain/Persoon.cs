using System;
using System.Collections.Generic;
using System.Text;

namespace VOCDomain
{
    public class Persoon
    {
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }

        // nav prop

        public List<Dier> DierenBinnenGebracht { get; set; } = new List<Dier>();
    }
}

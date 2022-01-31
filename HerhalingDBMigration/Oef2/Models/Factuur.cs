using System;
using System.Collections.Generic;
using System.Text;

namespace Oef2.Models
{
    public class Factuur
    {
        public int Id { get; set; }
        public int FactuurNummer { get; set; }
        public string KlantNaam { get; set; }

        //prop nav
        public List<Factuurlijn> Factuurlijnen { get; set; }
    }
}

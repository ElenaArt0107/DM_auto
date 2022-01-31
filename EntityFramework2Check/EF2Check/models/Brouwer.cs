using System;
using System.Collections.Generic;

#nullable disable

namespace EF2Check.models
{
    public partial class Brouwer
    {
        public int BrouwerNr { get; set; }
        public string BrouwerNaam { get; set; }
        public string Adres { get; set; }
        public int? PostCode { get; set; }
        public string Gemeente { get; set; }
        public int? Omzet { get; set; }
    }
}

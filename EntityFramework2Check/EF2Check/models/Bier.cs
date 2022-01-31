using System;
using System.Collections.Generic;

#nullable disable

namespace EF2Check.models
{
    public partial class Bier
    {
        public int BierNr { get; set; }
        public string BierNaam { get; set; }
        public int? BrouwerNr { get; set; }
        public int? SoortNr { get; set; }
        public float? Alchohol { get; set; }
        public int? Rating { get; set; }

        public List<Persoon> PplWithBier1 { get; set; } = new List<Persoon>();
        public List<Persoon> PplWithBier2 { get; set; } = new List<Persoon>();
    }
}

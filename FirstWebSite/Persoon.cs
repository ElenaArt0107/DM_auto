using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebSite
{
    public class Persoon
    {
        public int Lijftijd { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public string Volledigenaam => $"{Naam} {Voornaam}";
    }
}

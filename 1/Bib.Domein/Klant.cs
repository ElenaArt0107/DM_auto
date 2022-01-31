using System;
using System.Collections.Generic;
using System.Text;

namespace Bib.Domein
{
    public class Klant
    {
        public int Id { get; set; }
        public string  Voornaam { get; set; }
        public string Familienaam { get; set; }
        public List<Ontlening> Ontleningen { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Bib.Domein
{
    public class Artikel
    {
        public int Id { get; set; }
        public string Soort { get; set; }
        public string Titel { get; set; }
        public bool IsOntleend { get; set; }
        public List<Ontlening> Ontleningen { get; set; }

    }
}

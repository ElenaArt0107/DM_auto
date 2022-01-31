using System;
using System.Collections.Generic;
using System.Text;

namespace Bib.Domein
{
    public class Ontlening
    {
        public int Id { get; set; }
        public DateTime DateOntlening { get; set; }
        public Artikel ArtikelOntening { get; set; }
        public Klant KlantOntlening { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Oef2.Models
{
    public class Factuurlijn
    {
        public int Id { get; set; }
        public int ArtikelId { get; set; }
        public int FactuurId { get; set; }
        public int? Hoeveelheid { get; set; }


        //prop nav 
        public Artikel Artikel { get; set; }
        public Factuur Factuur { get; set; }
    }
}

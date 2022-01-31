using System;
using System.Collections.Generic;
using System.Text;

namespace BankDomain
{
    public class Klant
    {
        public int Id { get; set; }
        public string Adress { get; set; }
        public string Naam { get; set; }

        // nav properties

        public List<Rekening> KlantRekeningen { get; set; } = new List<Rekening>();
    }
}

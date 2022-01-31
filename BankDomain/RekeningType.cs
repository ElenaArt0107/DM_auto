using System;
using System.Collections.Generic;
using System.Text;

namespace BankDomain
{
    public class RekeningType
    {
        public int Id { get; set; }
        public string Naam { get; set; }

        // nav properties
        public List<Rekening> Rekeningen { get; set; }
    }
}

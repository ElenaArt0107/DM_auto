using System;
using System.Collections.Generic;
using System.Text;

namespace BankDomain
{
    public class Transactie
    {
        public int Id { get; set; }
        public DateTime TransactieDatum { get; set; }
        public string Omschrijving { get; set; }
        public decimal Bedrag { get; set; }

        // nav properties
        public Rekening RekeningTransactie { get; set; }
    }
}

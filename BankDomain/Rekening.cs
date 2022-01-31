using System;
using System.Collections.Generic;
using System.Text;

namespace BankDomain
{
    public class Rekening
    {
        public int Id { get; set; }
        public DateTime DateRekeningAangemaakt { get; set; }
        public decimal HuidigeBalans { get; set; }

        // nav properties

        public Klant Owner { get; set; }
        public RekeningType TypeRekening { get; set; }
        public List<Transactie> Transacties { get; set; } = new List<Transactie>();


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Rekening
    {
        public int Id { get; set; }
        public DateTime DateRekeningAangemaakt { get; set; }
        public decimal HuidigeBalans { get; set; }

        // nav properties

        public Klant KlantRekening { get; set; }
        public RekeningType TypeRekening { get; set; }
        public List<Transactie> Transacties { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Klant
    {
        public int Id { get; set; }
        public string Adress { get; set; }

        // nav properties

        public List <Rekening> KlantRekeningen { get; set; }
    }
}

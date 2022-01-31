using System;
using System.Collections.Generic;
using System.Text;

namespace VOCDomain
{
    public class Dier
    {
        public int Volgnummer { get; set; }
        public string Soort { get; set; }
        public DateTime BinnengebrachtOp { get; set; }
        
        private DateTime? _datumVrijgelaten;

        public DateTime? VrijgelatenOp
        {
            get { return _datumVrijgelaten; }
            set { _datumVrijgelaten = value; }
        }
        public Persoon BinnegebrachtDoor { get; set; }
    }
}

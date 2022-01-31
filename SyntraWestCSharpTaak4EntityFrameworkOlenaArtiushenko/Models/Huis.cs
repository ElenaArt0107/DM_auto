using System;
using System.Collections.Generic;
using System.Text;


namespace SyntraWestCSharpTaak4EntityFrameworkOlenaArtiushenko.Models
{
    public class Huis
    {
        public int Id { get; set; }

        public string HuisNummer { get; set; }
        
        public int StraatId { get; set; }

        //nav prop

        public Straat Straat { get; set; }
        public List<Persoon> Personen { get; set; } = new List<Persoon>();
    }
}

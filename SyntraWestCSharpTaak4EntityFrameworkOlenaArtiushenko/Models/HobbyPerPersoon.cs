using System;
using System.Collections.Generic;
using System.Text;

namespace SyntraWestCSharpTaak4EntityFrameworkOlenaArtiushenko.Models
{
    public class HobbyPerPersoon
    {
        public int Id { get; set; }
        public int PersoonId { get; set; }
        public int HobbyId { get; set; }

        //nav prop
        public Hobby Hobby { get; set; }
        public Persoon Persoon { get; set; }
    }
}

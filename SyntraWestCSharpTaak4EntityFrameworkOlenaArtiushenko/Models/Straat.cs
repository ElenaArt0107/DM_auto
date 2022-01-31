using System;
using System.Collections.Generic;
using System.Text;

namespace SyntraWestCSharpTaak4EntityFrameworkOlenaArtiushenko.Models
{
    public class Straat
    {

        public int Id { get; set; }
        public string Naam { get; set; }

        //prop nav

        public List<Huis> Huisen { get; set; }
    }
}

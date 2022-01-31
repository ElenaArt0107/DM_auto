using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotheekMapping.Model
{
    public class Author
    {
        public int Id { get; set; }
        public string Naam { get; set; }

        //nav prop

        public List<Boek> Boeken { get; set; } = new List<Boek>();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MuziekMapping.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Naam { get; set; }

        //nav prop
        public List<Lied> Lieden { get; set; } = new List<Lied>();
    }
}

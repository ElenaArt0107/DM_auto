using System;
using System.Collections.Generic;
using System.Text;

namespace MuziekMapping.Models
{
    public class Lied
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public int AlbumId { get; set; }

        public Album Album { get; set; }
    }
}

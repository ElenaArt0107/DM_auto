using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BibliotheekMapping.Model
{
    public class Genre
    {
        public int Id { get; set; }

        [MaxLength(255)]
        public string Naam { get; set; }

        //prop nav

        [InverseProperty(nameof(Boek.GenreVanBoek))]
        public List<Boek> Boeken { get; set; } = new List<Boek>();

    }
}

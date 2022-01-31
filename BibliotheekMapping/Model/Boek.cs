using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BibliotheekMapping.Model
{
    public class Boek
    {
        public int BoekID { get; set; }
        public int AutherID { get; set; }
        public string Titel { get; set; }

        [ForeignKey(nameof(GenreVanBoek))] // as a param take a nav prop for the foreign key
        public int? GenreId { get; set; }

        //nav prop
        public Author Author { get; set; }

        [InverseProperty(nameof(Genre.Boeken))]
        public Genre GenreVanBoek { get; set; }

        public List<BoekenPerOntlening> BoekenPerOntlening { get; set; } = new List<BoekenPerOntlening>();

    }
}

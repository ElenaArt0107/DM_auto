using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BibliotheekMapping.Model
{
    [Table ("Leden")]
    public class Klant
    {
        [Key]
        public int LidId { get; set; }
        
        [Column ("LidNaam")]
        public string Naam { get; set; }

        //nav prop

        public List<Ontlening> Ontleningen { get; set; }

    }
}

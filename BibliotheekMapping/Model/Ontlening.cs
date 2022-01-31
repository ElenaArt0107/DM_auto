using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BibliotheekMapping.Model
{
    public class Ontlening
    {
        public int Id { get; set; }

        [ForeignKey (nameof(Klant))]
        public int KalntId { get; set; }
        public DateTime Van { get; set; }
        public DateTime Voor { get; set; }

        //nav prop

        public Klant Klant { get; set; }
        public List<BoekenPerOntlening> BoekenPerOntlening { get; set; } = new List<BoekenPerOntlening>();

    }
}

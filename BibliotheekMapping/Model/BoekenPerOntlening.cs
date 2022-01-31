using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BibliotheekMapping.Model
{
    public class BoekenPerOntlening
    {
        public int Id { get; set; }

        //[ForeignKey]
        public int OntleningId { get; set; }
        public int BoekId { get; set; }

        //prop nav

        public Boek Boek { get; set; }
        public Ontlening Ontlening { get; set; }
    }
}

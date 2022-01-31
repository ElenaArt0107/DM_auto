using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Oef3.Models
{
    public class Werknemer
    {
        public int Id { get; set; }
       
        [Required]
        public string Naam { get; set; }
       
        [Required]
        public int AfdelingId { get; set; }
        public int? SpecialiteitId { get; set; }
       
        [Required]
        public int WerkgeverId { get; set; }

        //prop nav
        public Afdeling Afdeling { get; set; }
        public Specialiteit Specialiteit { get; set; }
        public Werkgever Werkgever { get; set; }
    }
}

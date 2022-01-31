using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Oef3.Models
{
    public class Specialiteit
    {
        public int Id { get; set; }

        [Required]
        public string Naam { get; set; }

        //prop nav 
        List<Werknemer> Werknemers = new List<Werknemer>();

    }
}

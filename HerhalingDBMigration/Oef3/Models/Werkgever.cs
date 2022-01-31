using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Oef3.Models
{
    public class Werkgever
    {
        public int Id { get; set; }

        [Required]
        public string Naam { get; set; }

        //nav prop
        List<Werknemer> Werknemers = new List<Werknemer>();

    }
}

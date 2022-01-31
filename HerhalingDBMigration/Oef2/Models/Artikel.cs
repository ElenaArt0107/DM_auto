using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Oef2.Models
{
    public class Artikel
    {
        public int Id { get; set; }

        [MaxLength(5)]
        [Required]
        public string Code { get; set; }

        // prop nav
        public List<Factuurlijn> Factuurlijnen { get; set; }
    }
}

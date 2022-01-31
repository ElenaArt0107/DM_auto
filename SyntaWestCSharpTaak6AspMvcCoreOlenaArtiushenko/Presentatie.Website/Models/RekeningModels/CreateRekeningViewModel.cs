using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Presentatie.Website.Models.RekeningModels
{
    public class CreateRekeningViewModel
    {
        [Required]
        [StringLength(50)]
        public string OpNaamVan { get; set; }
        [StringLength(20)]
        public string RekeningType { get; set; }
        [Range(0, 10000)]
        public decimal Balans { get; set; }
    }
}

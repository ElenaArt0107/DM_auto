using Microsoft.AspNetCore.Mvc.Rendering;
using Presentation.DMAutoservice.Models.BrandModels;
using System.Collections.Generic;

namespace Presentation.DMAutoservice.Models.PersonModels
{
    public class PersonViewModel
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }

        public List<BrandViewModel> Brands { get; set; } = new List<BrandViewModel>();
        public List<int> SelectedBrandIds { get; set; } = new List<int>();
    }
}

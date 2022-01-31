using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DMAutoservice.Domain.Models;

namespace Presentation.DMAutoservice.Models.UserCarModels
{
    public class CreateUserCarViewModel
    {
        public Person Person { get; set; }

       [Required]
        public int BrandId { get; set; }
        public List<Brand> BrandsForDropDown { get; set; } = new List<Brand>();
    }
}

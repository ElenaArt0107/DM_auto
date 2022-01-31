using DMAutoservice.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.DMAutoservice.Models.UserCarModels
{
    public class EditUserCarViewModel
    {
        //public Person Person { get; set; }
        public UserCar UserCar { get; set; }

        //[Required]
        //public int BrandId { get; set; }
        //[Required]
        //public int PersonId { get; set; }
        public List<Brand> BrandsForDropDown { get; set; } = new List<Brand>();
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DMAutoservice.Domain.Models
{
    public class UserCar
    {
        public int Id { get; set; }
        public int PersonId { get; set; }

        public int BrandId { get; set; }


        //TODO public Options ExtraOptions { get; set; }
        //nav properties:
        public Person Person { get; set; }

        public Brand Brand { get; set; }
    }
}

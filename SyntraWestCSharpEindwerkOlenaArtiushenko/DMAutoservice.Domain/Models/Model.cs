using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DMAutoservice.Domain.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public int BrandId { get; set; }

        //TODO public List<Generation> Generations { get; set; }

        //nav prop

        public Brand Brand { get; set; }
        public List<Generation> Generations { get; set; } = new List<Generation>();

        public override string ToString()
        {
            return Brand.ToString() + $"\nModel:\t\t{ModelName}";
        }
    }
}

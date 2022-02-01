using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DMAutoservice.Domain.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string BrandName { get; set; }

        //nav properties
        public List<Person> Persons { get; set; } = new List<Person>();
        public List<Model> Models { get; set; } =  new List<Model>();

        public override string ToString()
        {
            return $"Brand:\t\t{BrandName}";
        }
    }
}

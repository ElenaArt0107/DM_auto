using DMAutoservice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IBrandService
    {
        public Brand GetBrand(int id);
        public List<Brand> GetBrandsSortedOnBrandNameDesc();
        public void CreateBrand(Brand brand);
        public void DeleteBrand(int id);
        public void UpdateBrand(Brand brand);
    }

}

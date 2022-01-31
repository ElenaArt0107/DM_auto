using DMAutoservice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public interface IBrandRepository
    {
        public int CreateBrand(Brand brand);
        public void DeleteBrand(int id);
        public Brand GetBrand(int id);
        public List<Brand> GetBrands();
        public void UpdateBrand(Brand brand);
    }
}

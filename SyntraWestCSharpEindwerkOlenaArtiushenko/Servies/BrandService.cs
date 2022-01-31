using DAL;
using DMAutoservice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class BrandService: IBrandService
    {
        private readonly IBrandRepository _brandRepo;
        public BrandService(IBrandRepository brandRepo)
        {
            _brandRepo = brandRepo;
        }

        public void CreateBrand(Brand brand)
        {
            _brandRepo.CreateBrand(brand);
        }

        public void DeleteBrand(int id)
        {
            _brandRepo.DeleteBrand(id);
        }

        public Brand GetBrand(int id)
        {
           return _brandRepo.GetBrand(id);
        }

        public List<Brand> GetBrandsSortedOnBrandNameDesc()
        {
            return _brandRepo.GetBrands().OrderByDescending(x => x.BrandName).ToList();
        }

        public void UpdateBrand(Brand brand)
        {
            _brandRepo.UpdateBrand(brand);
        }
    }
}

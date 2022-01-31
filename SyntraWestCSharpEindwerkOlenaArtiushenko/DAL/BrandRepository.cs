using DMAutoservice.Domain;
using DMAutoservice.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class BrandRepository : IBrandRepository
    {
        //dependency 
        private readonly DMAutoserviceContext _context;
        public BrandRepository(DMAutoserviceContext context)
        {
            _context = context;
        }
        public int CreateBrand(Brand brand)
        {
            _context.Add(brand);
            _context.SaveChanges();
            return brand.Id;
        }

        public void DeleteBrand(int id)
        {
            Brand brand = GetBrand(id);
            _context.Remove(brand);
            _context.SaveChanges();
        }

        public Brand GetBrand(int id)
        {
            return _context.Brands
                 .Include(x => x.UserPerCar)
                 .Where(x => x.Id == id)
                 .FirstOrDefault();
        }

        public List<Brand> GetBrands()
        {
            return _context.Brands.
                ToList();
        }

        public void UpdateBrand(Brand brand)
        {
            Brand brandToUpdate = GetBrand(brand.Id);
            brandToUpdate.BrandName = brand.BrandName;
            _context.SaveChanges();
        }
    }
}

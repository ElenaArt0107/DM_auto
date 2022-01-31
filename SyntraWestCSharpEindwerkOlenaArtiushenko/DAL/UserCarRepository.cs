using DMAutoservice.Domain;
using DMAutoservice.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class UserCarRepository : IUserCarRepository
    {
        private readonly DMAutoserviceContext _context;
        public UserCarRepository(DMAutoserviceContext context)
        {
            _context = context;
        }
        public int CreateUserCar(UserCar userCar)
        {
            _context.Add(userCar);
            _context.SaveChanges();
            return userCar.Id;
        }

        public void DeleteUserCar(int id)
        {
            UserCar userCar = GetUserCar(id);
            _context.Remove(userCar);
            _context.SaveChanges();
        }

        public UserCar GetUserCar(int id)
        {
            return _context.UsersCars
                .Include(x => x.Brand)
                .Include(x => x.Person)
                 .Where(x => x.Id == id)
                 .FirstOrDefault();
        }

        public List<UserCar> GetUserCars()
        {
            return _context.UsersCars.
                ToList();
        }

        public void UpdateUserCar(UserCar userCar)
        {
            UserCar userCarToUpdate = GetUserCar(userCar.Id);
            userCarToUpdate.PersonId = userCar.Person.Id;
            userCarToUpdate.BrandId = userCar.Brand.Id;
            _context.SaveChanges();
        }
    }
}

using DAL;
using DMAutoservice.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class UserCarService : IUserCarService
    {
        private readonly IUserCarRepository _userCarRepo;
        private readonly IBrandRepository _brandRepo;
        private readonly IPersonRepository _personRepo;
        public UserCarService(IUserCarRepository userCarRepo, IPersonRepository personRepo, IBrandRepository brandRepo)
        {
            _userCarRepo = userCarRepo;
            _personRepo = personRepo;
            _brandRepo = brandRepo;
        }

        public void CreateUserCar(UserCar userCar)
        {
            _userCarRepo.CreateUserCar(userCar);
        }

        public void DeleteUserCar(int id)
        {
            _userCarRepo.DeleteUserCar(id);
        }

        public UserCar GetUserCar(int id)
        {
            return _userCarRepo.GetUserCar(id);
        }

        public List<UserCar> GetUserCarSortedOnPersonIdDsc(bool InclusiveChildObjects)
        {
            List<UserCar> usersCars = _userCarRepo.GetUserCars().OrderByDescending(x => x.PersonId).ToList();
            if (InclusiveChildObjects)
            {
                foreach (var uC in usersCars)
                {
                    IncludeChildObject(uC);
                }
            }
            return usersCars;
        }

        public void UpdateUserCar(UserCar userCar)
        {
            _userCarRepo.UpdateUserCar(userCar);
        }

        private void IncludeChildObject(UserCar userCar)
        {
            Person person = _personRepo.GetPerson(userCar.PersonId);
            Brand brand = _brandRepo.GetBrand(userCar.PersonId);

            userCar.Person = person;
            userCar.Brand = brand;
        }
    }
}


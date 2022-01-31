using DMAutoservice.Domain.Models;
using System.Collections.Generic;

namespace Services
{
    public interface IUserCarService
    {
        public void CreateUserCar(UserCar userCar);
        public void DeleteUserCar(int id);
        public UserCar GetUserCar(int id);
        public List<UserCar> GetUserCarSortedOnPersonIdDsc(bool InclusiveChildObjects);
        public void UpdateUserCar(UserCar userCar);
    }
}
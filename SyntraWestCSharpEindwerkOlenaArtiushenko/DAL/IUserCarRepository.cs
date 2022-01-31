using DMAutoservice.Domain.Models;
using System.Collections.Generic;

namespace DAL
{
    public interface IUserCarRepository
    {
        public int CreateUserCar(UserCar userCar);
        public void DeleteUserCar(int id);
        public UserCar GetUserCar(int id);
        public void UpdateUserCar(UserCar userCar);
        public List<UserCar> GetUserCars();
    }
}
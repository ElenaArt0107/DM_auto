using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DMAutoservice.Domain.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }

        public string ProperName => $"{Name} {Surname}";

        //nev prop

        public List<UserCar> CarsPerPerson { get; set; } = new List<UserCar>();
        public List<RolePerPerson> RolesPerPerson { get; set; } = new List<RolePerPerson>();


    }
}

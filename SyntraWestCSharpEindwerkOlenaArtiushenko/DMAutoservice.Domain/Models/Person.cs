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

        public string FullName => $"{Name} {Surname}";

        //nev prop

        public virtual List<Brand> Brands { get; set; } = new List<Brand>();
        public virtual List<RolePerPerson> Roles { get; set; } = new List<RolePerPerson>();


    }
}

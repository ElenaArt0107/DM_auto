using System;
using System.Collections.Generic;
using System.Text;

namespace DMAutoservice.Domain.Models
{
    public class RolePerPerson
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int UserId { get; set; }

        //nav prop

        public Person Person { get; set; }
        public User User { get; set; }
    }
}

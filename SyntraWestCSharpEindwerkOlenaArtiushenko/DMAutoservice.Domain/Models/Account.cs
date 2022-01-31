using System;
using System.Collections.Generic;
using System.Text;

namespace DMAutoservice.Domain.Models
{
    public class Account : EntityBase
    {
        //public int Id { get; set; } // inheriting from EntityBase

        public string LoginName { get; set; }
        public string Password { get; set; }
        public int PersonId { get; set; }

        //public Role Role { get; set; }
        //nav prop
        public Person Person { get; set; }

        public List<AccountRights> AccountRights { get; set; } = new List<AccountRights>();
    }
}
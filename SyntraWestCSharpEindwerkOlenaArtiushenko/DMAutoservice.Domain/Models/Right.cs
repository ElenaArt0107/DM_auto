using System;
using System.Collections.Generic;
using System.Text;

namespace DMAutoservice.Domain.Models
{
    public class Right:EntityBase
    {
        //public int Id { get; set; }
        public string InternalCode { get; set; }
        public string Name { get; set; }

        //prop nav
        public List<AccountRights> AccountsPerRight { get; set; } = new List<AccountRights>();
    }
}

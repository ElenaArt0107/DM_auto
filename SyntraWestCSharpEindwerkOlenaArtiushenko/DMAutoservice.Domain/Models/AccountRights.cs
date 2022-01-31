using System;
using System.Collections.Generic;
using System.Text;

namespace DMAutoservice.Domain.Models
{
    public class AccountRights : EntityBase
    {
        //public int Id { get; set; }
        public int AccountId { get; set; }
        public int RightId { get; set; }

        //nav prop

        public Right Right { get; set; }
        public Account Account { get; set; }
    }
}

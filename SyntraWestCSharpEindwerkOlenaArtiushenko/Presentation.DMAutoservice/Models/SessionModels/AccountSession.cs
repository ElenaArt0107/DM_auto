using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.DMAutoservice.Models.SessionModels
{
    public class AccountSession
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string UserName { get; set; }
        public List<string> Rights { get; set; } = new List<string>();
    }
}

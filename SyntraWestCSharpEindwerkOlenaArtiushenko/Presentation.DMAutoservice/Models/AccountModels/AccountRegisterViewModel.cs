using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.DMAutoservice.Models.AccountModels
{
    public class AccountRegisterViewModel
    {
        [Required]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password1 { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password1", ErrorMessage = "The password is not the same")]
        public string Password2 { get; set; }

        public string ErrorMessage { get; set; }
    }
}

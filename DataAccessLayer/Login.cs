using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DapperDataAccessLayer
{
    public class Login
    {

        [Required]
        [EmailAddress(ErrorMessage = "Enter Valid Email ID")]
        public string EmailID { get; set; }

        [Required]
        [PasswordPropertyText]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8}$",
         ErrorMessage = "Password must meet requirements")]
        public string Password {get; set;} 



    }
}

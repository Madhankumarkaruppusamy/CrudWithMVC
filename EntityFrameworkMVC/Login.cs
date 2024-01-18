using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkMVC
{
   public  class Login
    {

        [Required]
        [EmailAddress(ErrorMessage = "Required valid Emailid")]
        public string EmailID { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z]){8-20}$",
         ErrorMessage = "Password must meet requirements")]
        public string Password { get; set; }
    }
}

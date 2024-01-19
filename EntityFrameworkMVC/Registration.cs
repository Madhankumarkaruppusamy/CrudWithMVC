using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkMVC
{
    public  class Registration
    {
        [Key]
        public long RegistrationId { get; set; }
        [Required (ErrorMessage ="Enter Your EmailID")]
        public string Username { get; set; }
        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[^\da-zA-Z]).{8,20}$",
         ErrorMessage = "Password must meet requirements 1 Uppercase, 1 Lowercase, 1 Digit, and 1 Special Character with total of 8 to 20 Characters")]
        public string Password { get; set; }
    }
}

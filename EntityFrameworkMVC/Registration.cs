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

        public string Password { get; set; }
       // public IEnumerable<Registration> Registrations { get; set; }
    }
}

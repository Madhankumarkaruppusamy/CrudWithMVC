using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DapperDataAccessLayer
{
    public class Cricketer
    {
        [DisplayName("Cricketer ID")]
        public long CricketerId { get; set; }


        [Required(ErrorMessage = "Please Enter Your Name")]
        [StringLength(30)]
        [Display(Name = "Player Name")]
        public string CricketerName { get; set; }

        [Range(1,50000,ErrorMessage ="Enter valid ODI palyed")]
        [Required(ErrorMessage = "Please Enter Your Total ODI")]
        [DisplayName("ODI Played")]
        public long TotalODI { get; set; }

        [Range(1,50000,ErrorMessage ="Score cannot be 0")] 
        [Required(ErrorMessage = "Please Enter Your Total Score")]
        [DisplayName("Total Score")]
        public long TotalScore { get; set; }

        [Range(0, 50000, ErrorMessage = "Fifties cannot be lesser than 0")]
        [Required(ErrorMessage = "Please Enter Your Fifties")]
        public long Fifties { get; set; }

        [Range(0, 50000, ErrorMessage = "Hundreds cannot be lesser than 0")]
        [Required(ErrorMessage = "Please Enter Your Hundreds")]
        public long Hundreds { get; set; }
        public long LocationId { get; set; }
        public List<Location> Location { get; set; }
    }
}
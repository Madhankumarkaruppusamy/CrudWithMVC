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


        [Required(ErrorMessage = "Please Enter your Name")]
        [StringLength(30)]
        [Display(Name = "Player Name")]
        public string CricketerName { get; set; }


        [Required(ErrorMessage = "Please Enter your Total ODI")]
        [DisplayName("ODI Played")]
        public long TotalODI { get; set; }


        [Required(ErrorMessage = "Please Enter your Total Score")]
        [DisplayName("Total Score")]
        public long TotalScore { get; set; }


        [Required(ErrorMessage = "Please Enter your Fifties")]
        public long Fifties { get; set; }


        [Required(ErrorMessage = "Please Enter your Hundreds")]
        public long Hundreds { get; set; }
    }
}
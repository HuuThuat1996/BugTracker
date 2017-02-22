using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BugTracker.Models
{
    public class Infomation
    {
        [Required]
        [RegularExpression("([a-zA-Z])*", ErrorMessage = "Letters only")]
        public string FullName { set; get; }
        [Required]
        [EmailAddress]
        public string Email { set; get; }
        [Required]
        [RegularExpression("([0-9])*", ErrorMessage = "Numbers only")]
        public string Phone { get; set; }
        [Required]
        public bool? Attend { get; set; }
    }
}
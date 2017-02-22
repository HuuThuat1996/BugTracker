using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BugTracker.Models
{
    public class LogIn
    {
        [Required]
        [RegularExpression("([a-zA-Z])*", ErrorMessage = "Letters only")]
        public string Name { set; get; }
        [Required]
        [RegularExpression("([a-zA-Z0-9])*", ErrorMessage = "Letters and Numbers only")]
        public string PassWord { get; set; }
    }
}
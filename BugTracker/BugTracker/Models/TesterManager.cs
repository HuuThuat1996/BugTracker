using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BugTracker.Models
{
    public class TesterManager
    {
        [Required]
        [RegularExpression("([a-zA-Z0-9])*", ErrorMessage = "Letters and Numbers only")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 7)]
        public string Password { get; set; }
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [RegularExpression("([0-9])*", ErrorMessage = "Numbers only")]
        public string Phone { get; set; }
    }
}
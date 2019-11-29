using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SessionDemo.Models
{
    // TODO 05: Klasse aanmaken
    public class Login
    {
        [Required(ErrorMessage = "Fill in a valid e-mail address.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Type your password.")]
        public string Password { get; set; }
    }
}

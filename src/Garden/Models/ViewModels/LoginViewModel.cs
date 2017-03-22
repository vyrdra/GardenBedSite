using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Garden.Models.ViewModels
{
    public class LoginViewModel
    {   
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}

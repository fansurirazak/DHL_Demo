using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DHL_Demo.Models
{
    public class User
    {
        [Display(Name = "Username")]
        public string username { get; set; } = string.Empty;
        [Display(Name = "Password")]
        public string password { get; set; } = string.Empty;
    }
}

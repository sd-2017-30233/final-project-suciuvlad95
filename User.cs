using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserID { get; set; }
       
        [Display(Name = "Username")]
        public string Username { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string email { get; set; }

        [Required(ErrorMessage = "Password is requierd")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
       
    }

   
    public class Logare
    {
        [Key]
        public string email { get; set; }
        public string password { get; set; }
    }

}



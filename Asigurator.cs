using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("Asigurator")]
    public class Asigurator
    {
        [Key]
        public int asigratorID { get; set; }

        public string nume { get; set; }

     
        public string email { get; set; }

    }
}
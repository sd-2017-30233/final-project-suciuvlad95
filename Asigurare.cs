using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace WebApplication1.Models
{
    [Table("Asigurare")]
    public class Asigurare
    {
        [Key]
        public int asigID { get; set; }

        public int pret { get; set; }

    }
}
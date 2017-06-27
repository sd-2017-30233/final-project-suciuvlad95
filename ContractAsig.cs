using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("ContractAsig")]
    public class ContractAsig
    {
        [Key]
        public int contractID { get; set; }

        public int UserID { get; set; }

        public int asigID { get; set; }

        public int asigratorID { get; set; }

        public string dataMea { get; set; }

        public string descriere { get; set; }
    }
}
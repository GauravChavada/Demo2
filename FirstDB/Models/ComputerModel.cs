using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FirstDB.Models
{
    [Table("Computers")]
    public class ComputerModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Computer_ID { get; set; }
        public string Company_Name { get; set; }
        public decimal Prize { get; set; }
        public DateTime Document_Date { get; set; }
        public string OS { get; set; }
    }
}
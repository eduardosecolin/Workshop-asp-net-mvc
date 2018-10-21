using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SaleWebMvc.Models {
    
    [Table(name:"DEPARTAMENTOS")]
    public class Department {

        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(20)]
        public string name { get; set; }
    }
}

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
        [Column(name:"nome")]
        public string name { get; set; }

        public ICollection<Seller> sellers = new List<Seller>();

        public Department(){

        }

        public Department(string name) {
            this.name = name;
        }

        public void AddSeller(Seller seller){
            sellers.Add(seller);
        }

        public void RemoveSeller(Seller seller){
            sellers.Remove(seller);
        }

        public double TotalSales(DateTime initial, DateTime final){
            return sellers.Sum(s => s.TotalSales(initial, final));
        }
    }
}

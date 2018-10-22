using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace SaleWebMvc.Models {

    [Table(name:"VENDEDORES")]
    public class Seller {

        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        [Column(name:"nome_vendedor")]
        public string name { get; set; }
        [StringLength(30)]
        public string email { get; set; }
        [Column(name:"salario_base")]
        public double baseSalary { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Column(name:"data_nascimento")]
        public DateTime birthDate { get; set; }

        public Department department { get; set; }

        public ICollection<SalesRecord> sales = new List<SalesRecord>();

        public Seller(){

        }

        public Seller(string name, string email, double baseSalary, DateTime birthDate, Department department) {
            this.name = name;
            this.email = email;
            this.baseSalary = baseSalary;
            this.birthDate = birthDate;
            this.department = department;
        }

        public void AddSales(SalesRecord salesRecord){
            sales.Add(salesRecord);
        }

        public void RemoveSales(SalesRecord salesRecord){
            sales.Remove(salesRecord);
        }

        public double TotalSales(DateTime initial, DateTime final){
            return sales.Where(sr => sr.date >= initial && sr.date <= final).Sum(sr => sr.amount);
        }
    }

}

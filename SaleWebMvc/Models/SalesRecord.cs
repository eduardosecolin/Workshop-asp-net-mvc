using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using SaleWebMvc.Models.Enums;

namespace SaleWebMvc.Models {

    [Table(name:"VENDAS")]
    public class SalesRecord {

        [Key]
        public int id { get; set; }
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        [Column(name:"data_venda")]
        public DateTime date { get; set; }
        [Column(name:"total")]
        public double amount { get; set; }
        public SaleStatus status { get; set; }

        public Seller seller { get; set; }

        public SalesRecord(){

        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller) {
            this.id = id;
            this.date = date;
            this.amount = amount;
            this.status = status;
            this.seller = seller;
        }
    }
}

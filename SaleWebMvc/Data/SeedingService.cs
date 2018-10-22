using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaleWebMvc.Models;
using SaleWebMvc.Models.Enums;

namespace SaleWebMvc.Data {
    public class SeedingService {

        private SaleWebMvcContext _context;

        public SeedingService( SaleWebMvcContext context){
            _context = context;
        }

        public void Seed(){
          if(_context.Department.Any() || _context.Seller.Any() || _context.SaleRecords.Any()){
                return; // banco de dados já foi populado
          }
            Department d1 = new Department("Eletronicos");
            Department d2 = new Department("Computadore");
            Department d3 = new Department("Livros");
            Department d4 = new Department("Roupas");

            Seller s1 = new Seller("José", "jose@email.com", 3200.00, new DateTime(1959, 12, 19), d3);
            Seller s2 = new Seller("Marcia", "marcia@email.com", 3200.00, new DateTime(1965, 06, 05), d4);
            Seller s3 = new Seller("Roseli", "roseli@email.com", 3200.00, new DateTime(1983, 05, 23), d4);
            Seller s4 = new Seller("Patricia", "paty@email.com", 3200.00, new DateTime(1990, 11, 24), d4);
            Seller s5 = new Seller("Maria", "maria@email.com", 3200.00, new DateTime(2006, 05, 19), d3);
            Seller s6 = new Seller("eduardo", "edu@email.com", 3200.00, new DateTime(2007, 12, 26), d1);
            Seller s7 = new Seller("Carlos Eduardo", "du@email.com", 3200.00, new DateTime(1984, 08, 11), d1);

            SalesRecord sl1 = new SalesRecord(new DateTime(2017, 02, 20), 400.00, SaleStatus.Billed, s1);
            SalesRecord sl2 = new SalesRecord(new DateTime(2018, 12, 20), 200.00, SaleStatus.Canceled, s2);
            SalesRecord sl3 = new SalesRecord(new DateTime(2016, 03, 10), 400.00, SaleStatus.Pending, s3);
            SalesRecord sl4 = new SalesRecord(new DateTime(2018, 05, 15), 400.00, SaleStatus.Billed, s4);
            SalesRecord sl5 = new SalesRecord(new DateTime(2018, 04, 12), 400.00, SaleStatus.Billed, s5);
            SalesRecord sl6 = new SalesRecord(new DateTime(2018, 03, 25), 400.00, SaleStatus.Pending, s6);
            SalesRecord sl7 = new SalesRecord(new DateTime(2018, 09, 14), 400.00, SaleStatus.Billed, s7);
            SalesRecord sl8 = new SalesRecord(new DateTime(2015, 08, 17), 400.00, SaleStatus.Canceled, s1);
            SalesRecord sl9 = new SalesRecord(new DateTime(2017, 06, 18), 400.00, SaleStatus.Billed, s5);

            _context.AddRange(d1, d2, d3, d4);
            _context.AddRange(s1, s2, s3, s4, s5, s6, s7);
            _context.AddRange(sl1, sl2, sl3, sl4, sl5, sl6, sl7, sl8, sl9);

            _context.SaveChanges();
        }
    }
}

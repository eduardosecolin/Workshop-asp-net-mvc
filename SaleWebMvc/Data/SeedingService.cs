using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaleWebMvc.Models;

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
            //Department department = new Department();
        }
    }
}

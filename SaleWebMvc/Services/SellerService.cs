using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaleWebMvc.Models;

namespace SaleWebMvc.Services {
    public class SellerService {

        private readonly SaleWebMvcContext _context;

        public SellerService(SaleWebMvcContext context){
            _context = context;
        }

        public List<Seller> FindAll(){
            return _context.Seller.ToList();
        }

        public void Insert(Seller seller){
            seller.department = _context.Department.First();
            _context.Add(seller);
            _context.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleWebMvc.Models.ViewModels {
    public class SellerFormViewModel {

      public Seller seller { get; set; }
      public ICollection<Department> departments { get; set; }

    }
}

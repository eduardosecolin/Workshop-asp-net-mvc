using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleWebMvc.Services.Exceptions {
    public class DbConCurrencyException : ApplicationException {

      public DbConCurrencyException(string message) : base(message) {

      }
    }
}

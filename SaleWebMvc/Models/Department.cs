﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleWebMvc.Models {
    public class Department {

        private int id;
        private string name;

        public int Id{ get{ return id; } set{ id = value; } }
        public string Name{ get{ return name; } set{ name = value; } }
    }
}

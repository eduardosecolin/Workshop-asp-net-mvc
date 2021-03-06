﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaleWebMvc.Models;
using Microsoft.EntityFrameworkCore;
using SaleWebMvc.Services.Exceptions;

namespace SaleWebMvc.Services {
    public class SellerService {

        private readonly SaleWebMvcContext _context;

        public SellerService(SaleWebMvcContext context) {
            _context = context;
        }

        public List<Seller> FindAll() {
            return _context.Seller.ToList();
        }

        public void Insert(Seller seller) {
            _context.Add(seller);
            _context.SaveChanges();
        }

        public Seller FindById(int id) {
            return _context.Seller.Include(x => x.department).FirstOrDefault(x => x.id == id);
        }

        public void Remove(int id) {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Seller seller) {
            if (!_context.Seller.Any(x => x.id == seller.id)) {
                throw new NotFoundException("Id não encontrado!");
            }

            try {
                _context.Update(seller);
                _context.SaveChanges();
            }catch(DbUpdateConcurrencyException e){
                throw new DbConCurrencyException(e.Message);
            }
        }
    }
}

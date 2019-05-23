using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Interfaces;
using WebApplication5.Models;

namespace WebApplication5.Repository
{
    public class ProductRepository : IDisposable, IProductRepository
    {
        private AppDbContext db = new AppDbContext();

        public bool Add(Product product)
        {
            db.Product.Add(product);
            int res = db.SaveChanges();
            return res > 0 ? true : false;
        }

        public bool Delete(Product product)
        {
            db.Product.Remove(product);
            int res = db.SaveChanges();
            return res > 0 ? true : false;
        }

        public IEnumerable<Product> GetAll()
        {
            return db.Product;
        }

        public Product GetById(int id)
        {
            return db.Product.FirstOrDefault(x => x.ProductId == id);
        }

        public bool Update(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
            try
            {
                int res = db.SaveChanges();
                return res > 0 ? true : false;
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (db != null)
                {
                    db.Dispose();
                    db = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

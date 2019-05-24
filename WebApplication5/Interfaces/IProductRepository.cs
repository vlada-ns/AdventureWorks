using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Models;

namespace WebApplication5.Interfaces
{
    public interface IProductRepository
    {
        //IEnumerable<Product> GetAll();
        //Task<IList<Product>> GetAll();
        IList<Product> GetAll();
        Product GetById(int id);
        //IEnumerable<Product> GetByGodina(int godina);
        //IEnumerable<Product> GetPretraga(int najmanje, int najvise);
        bool Add(Product product);
        bool Update(Product product);
        bool Delete(Product product);
    }
}

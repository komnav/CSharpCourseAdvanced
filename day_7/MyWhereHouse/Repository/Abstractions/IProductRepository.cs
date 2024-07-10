using MyWhereHouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWarehouse.Repository.Abstractions
{
    public interface IProductRepository
    {
        void Add(string productName, int quantity);

        void UpdateQuantity(string productName, int quantity);

        void Delete(string name);

        IEnumerable<Product> GetAll();

        Product ProductGetByName(string name);
    }
}

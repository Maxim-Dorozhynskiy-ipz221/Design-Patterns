using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Warehouse : IWarehouse
    {
        private List<IProduct> products;

        public Warehouse()
        {
            products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            products.Add(product);
        }

        public void RemoveProduct(string productName)
        {
            var product = products.Find(p => p.Name == productName);
            if (product != null)
            {
                products.Remove(product);
            }
        }

        public IProduct FindProduct(string productName)
        {
            return products.Find(p => p.Name == productName);
        }

        public List<IProduct> GetAllProducts()
        {
            return new List<IProduct>(products);
        }
    }
}



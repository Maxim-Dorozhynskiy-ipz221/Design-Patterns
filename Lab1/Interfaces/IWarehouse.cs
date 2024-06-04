using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IWarehouse
{
    void AddProduct(IProduct product);
    void RemoveProduct(string productName);
    IProduct FindProduct(string productName);
    List<IProduct> GetAllProducts();
}
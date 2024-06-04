using Lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IProduct
{
    string Name { get; }
    Money UnitPrice { get; }
    int Quantity { get; }
    string Category { get; }
    int UniqueID { get; }
    void ChangePrice(Money newPrice);
    void UpdateQuantity(int newQuantity);
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Product : IProduct
    {
        public string Name { get; private set; }
        public Money UnitPrice { get; private set; }
        public int Quantity { get; private set; }
        public string Category { get; private set; }
        public int UniqueID { get; private set; }

        public Product(string name, Money unitPrice, int quantity, string category, int uniqueID)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            UnitPrice = unitPrice ?? throw new ArgumentNullException(nameof(unitPrice));
            Quantity = quantity;
            Category = category ?? throw new ArgumentNullException(nameof(category));
            UniqueID = uniqueID;
        }

        public void ChangePrice(Money newPrice)
        {
            UnitPrice = newPrice ?? throw new ArgumentNullException(nameof(newPrice));
            Console.WriteLine($"Ціна продукту '{Name}' змінена на {newPrice.WholePart}.{newPrice.FractionalPart:00}.");
        }

        public void UpdateQuantity(int newQuantity)
        {
            Quantity = newQuantity;
            Console.WriteLine($"Кількість продукту '{Name}' оновлена: {Quantity}");
        }

        public override string ToString()
        {
            return $"Назва: {Name}, Ціна: {UnitPrice}, Кількість: {Quantity}, Категорія: {Category}";
        }
    }
}

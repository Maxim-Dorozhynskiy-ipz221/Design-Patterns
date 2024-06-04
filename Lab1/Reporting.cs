using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Reporting : IReporting
    {
        private IWarehouse warehouse;
        private int uniqueIDCounter;

        public Reporting(IWarehouse warehouse)
        {
            this.warehouse = warehouse;
            uniqueIDCounter = 1;

            foreach (var product in warehouse.GetAllProducts())
            {
                if (product.UniqueID >= uniqueIDCounter)
                {
                    uniqueIDCounter = product.UniqueID + 1;
                }
            }
        }

        public int GetUniqueID()
        {
            return uniqueIDCounter++;
        }

        public void PrintIncomeStatement(string productName)
        {
            Console.WriteLine($"Прибуткова накладна: Додано {productName}");
        }

        public void PrintExpenseStatement(string productName)
        {
            Console.WriteLine($"Видаткова накладна: Видалено {productName}");
        }
    }
}

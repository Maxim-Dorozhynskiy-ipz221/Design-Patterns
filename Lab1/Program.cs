using System;
using System.Collections.Generic;
using System.Xml;
using Newtonsoft.Json;

    namespace Lab1
    {
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            IWarehouse warehouse = new Warehouse();
            IReporting reporting = new Reporting(warehouse);

            while (true)
            {
                Console.WriteLine("Оберіть дію:");
                Console.WriteLine("1. Додати товар");
                Console.WriteLine("2. Видалити товар");
                Console.WriteLine("3. Переглянути список товарів");
                Console.WriteLine("4. Знайти товар");
                Console.WriteLine("5. Змінити ціну товару");
                Console.WriteLine("6. Завершити");

                var input = Console.ReadLine();
                if (input == "6")
                {
                    break;
                }

                switch (input)
                {
                    case "1":
                        AddProduct(warehouse, reporting);
                        break;
                    case "2":
                        DeleteProduct(warehouse, reporting);
                        break;
                    case "3":
                        ViewAllProducts(warehouse);
                        break;
                    case "4":
                        FindProduct(warehouse);
                        break;
                    case "5":
                        ChangeProductPrice(warehouse);
                        break;
                    default:
                        Console.WriteLine("Неправильний вибір, спробуйте ще раз.");
                        break;
                }
            }

            SaveProductsToFile(warehouse.GetAllProducts(), "inventory.json");
        }

        static void AddProduct(IWarehouse warehouse, IReporting reporting)
        {
            Console.WriteLine("Додавання товару:");
            Console.Write("Назва: ");
            string name = Console.ReadLine();
            Console.Write("Введіть цілу частину ціни: ");
            int wholePart = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть дробову частину ціни: ");
            int fractionalPart = Convert.ToInt32(Console.ReadLine());
            Money unitPrice = new Money(wholePart, fractionalPart);
            Console.Write("Кількість: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Категорія: ");
            string category = Console.ReadLine();

            int uniqueID = reporting.GetUniqueID();
            var product = new Product(name, unitPrice, quantity, category, uniqueID);
            warehouse.AddProduct(product);
            reporting.PrintIncomeStatement(name);

            Console.WriteLine("Товар додано успішно.");
        }

        static void DeleteProduct(IWarehouse warehouse, IReporting reporting)
        {
            Console.WriteLine("Видалення товару:");
            Console.Write("Назва: ");
            string name = Console.ReadLine();

            var productToRemove = warehouse.FindProduct(name);
            if (productToRemove != null)
            {
                warehouse.RemoveProduct(name);
                reporting.PrintExpenseStatement(name);
                Console.WriteLine($"Продукт '{name}' видалено успішно.");
            }
            else
            {
                Console.WriteLine($"Продукт '{name}' не знайдено.");
            }
        }

        static void ViewAllProducts(IWarehouse warehouse)
        {
            Console.WriteLine("Список товарів:");
            foreach (var product in warehouse.GetAllProducts())
            {
                Console.WriteLine(product.ToString());
            }
        }

        static void FindProduct(IWarehouse warehouse)
        {
            Console.WriteLine("Пошук товару:");
            Console.Write("Назва: ");
            string name = Console.ReadLine();

            var product = warehouse.FindProduct(name);
            if (product != null)
            {
                Console.WriteLine(product.ToString());
            }
            else
            {
                Console.WriteLine($"Продукт '{name}' не знайдено.");
            }
        }

        static void ChangeProductPrice(IWarehouse warehouse)
        {
            Console.WriteLine("Зміна ціни товару:");
            Console.Write("Назва: ");
            string name = Console.ReadLine();

            var product = warehouse.FindProduct(name);
            if (product != null)
            {
                Console.Write("Введіть нову цілу частину ціни: ");
                int newWholePart = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введіть нову дробову частину ціни: ");
                int newFractionalPart = Convert.ToInt32(Console.ReadLine());
                product.ChangePrice(new Money(newWholePart, newFractionalPart));
            }
            else
            {
                Console.WriteLine($"Продукт '{name}' не знайдено.");
            }
        }

        static void SaveProductsToFile(List<IProduct> products, string fileName)
        {
            string json = JsonConvert.SerializeObject(products, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(fileName, json);
        }

        static List<IProduct> LoadProductsFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);
                return JsonConvert.DeserializeObject<List<IProduct>>(json);
            }
            return new List<IProduct>();
        }
    }
}






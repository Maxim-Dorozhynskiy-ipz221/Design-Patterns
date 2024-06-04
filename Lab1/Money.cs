using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab1
{
    public class Money
    {
        public int WholePart { get; set; }
        public int FractionalPart { get; set; }

        public Money(int wholePart, int fractionalPart)
        {
            WholePart = wholePart;
            FractionalPart = fractionalPart;
        }

        public void DisplayAmount()
        {
            Console.WriteLine($"Сума: {WholePart}.{FractionalPart:00}");
        }

        public override string ToString()
        {
            return $"{WholePart}.{FractionalPart:00}";
        }
    }
}
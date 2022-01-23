using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace mathematics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Min(5, 10)); // prints 5, since its the lowest number
            Console.WriteLine(Math.Max(5, -10)); // opposite of above function
            Console.WriteLine(Math.Sqrt(144)); // finds square root of number
            Console.WriteLine(Math.Abs(-22.15)); // makes it a positive absolute number
            Console.WriteLine(Math.Round(23.65)); // rounds to nearest whole number
            Console.WriteLine(Math.Floor(42.1)); // rounds to number above, e.g 1.3 --- 2
        }
    }
}
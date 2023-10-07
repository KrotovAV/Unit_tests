using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaterApp1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            double p = 100;
            double d = 5;

            var res1 = Calc.СalcDiscount(p, d);
            Console.WriteLine($"Price: {p}, Discount: {d} %");
            Console.WriteLine($"Discount price: {res1}");
        }
    }
}

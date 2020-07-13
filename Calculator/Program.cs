using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum, sub, mult, div;
            Console.WriteLine("enter first and second no.");
            a = Convert.ToInt16(Console.ReadLine());
            b = Convert.ToInt16(Console.ReadLine());
            sum = a + b;
            Console.WriteLine("sum is");
            Console.WriteLine(sum);
            sub = a - b;
            Console.WriteLine("difference is");
            Console.WriteLine(sub);
            mult = a * b;
            Console.WriteLine("product is");
            Console.WriteLine(mult);
            div = a / b;
            Console.WriteLine("division is");
            Console.WriteLine(div);
        }
    }
}

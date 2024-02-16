using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x,s;
            Console.Write("Введите число");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            s = 5 * Math.Sin(x) - 7 * Math.Cos(x);
        }
    }
}

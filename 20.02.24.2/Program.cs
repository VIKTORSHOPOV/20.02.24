using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._02._24._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double D = b * b - 4 * a * c;
            Console.WriteLine($"x1 = {(-b + Math.Sqrt(D)) / 2 * a:F2}");
            Console.WriteLine($"x2 = {(-b - Math.Sqrt(D)) / 2 * a:F2}");
        }
    }
}

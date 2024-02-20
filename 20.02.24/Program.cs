using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._02._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> list = new List<double>();
            for (int i = 0; i < 3; i++)
            {
                list.Add(double.Parse(Console.ReadLine()));
            }
            Console.WriteLine(Triangle(list[0], list[1], list[2]));
        }

        public static string Triangle(double a, double b, double c)
        {
            return (a == b && b == c) ? "Ravnostranen" : (a == b || a == c || b == c) ? "Ravnobedren" : "Raznostranen";
        }
    }
}

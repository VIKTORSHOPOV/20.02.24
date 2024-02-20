using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._02._24._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sum = new List<int>();
            while (true)
            {
                int input = int.Parse(Console.ReadLine());
                if (input == 0)
                    break;
                sum.Add(input);
            }
            Console.WriteLine("Sum = " + sum.Sum().ToString("N0"));
        }
    }
}

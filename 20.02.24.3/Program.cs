using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._02._24._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var numbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(i);
            }
            numbers.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            numbers.Reverse();
            numbers.ForEach(x => Console.Write(x + " "));

        }
    }
}

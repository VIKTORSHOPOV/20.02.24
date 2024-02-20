using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._02._24._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print(10);
        }

        static void Print(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                //mesta
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                //cifri namalqvash
                for (int k = i; k >= 0; k--)
                {
                    Console.Write(k);
                }
                //cifri uvelichavash
                for (int l = 1; l <= i; l++)
                {
                    Console.Write(l);
                }
                Console.WriteLine();
            }
        }
    }
}

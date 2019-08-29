using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0702A1Minimax
{
    class Program
    {
        static int Min(int a, int b)
        {
            if (a > b)
                return b;
            else
                return a;
        }

        static int Max(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Bitte Zahl eins eingeben:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Bitte Zahl zwei eingeben:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Die grössere Zahl ist {0}, die kleinere Zahl ist {1}", Max(a, b), Min(a, b));
        }
    }
}

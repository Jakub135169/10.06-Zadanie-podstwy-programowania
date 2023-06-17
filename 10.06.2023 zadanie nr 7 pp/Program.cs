using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._06._2023_zadanie_nr_7_pp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("podaj n  ");
            if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.WriteLine("nieprawidłowe dane");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Pary liczb o sumie {0}:", n);
                podajpary(n);
            }
        }

        public static void podajpary(int n)
        {
            for (int i = 1; i <= n / 2; i++)
            {
                int j = n - i;
                Console.WriteLine("{0} + {1} = {2}", i, j, n);
                Console.ReadKey();
            }
        }
    }
    }


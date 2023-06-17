using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._06._2023_zadanie_nr_5_pp
{
    internal class Program
        
    {
        //Napisz algorytm, który sprawdzi, czy wprowadzona liczba x jest silnią liczby n i jeśli
        //tak, to niech wypisze n.
        static void Main(string[] args)
        {
            
            Console.WriteLine("podaj liczbe x");
            int x = int.Parse(Console.ReadLine());

            int n = CheckFactorial(x);

            if(n>0)
            {
                Console.WriteLine($"liczba x jest silnią liczby {n}");
                Console.ReadKey();
             }
            else
            {
                Console.WriteLine($"liczba x nie jest silnią liczby {n}");
                Console.ReadKey();
            }
        }
        public static int CheckFactorial(int x)
        {
            int n = 0;
            if (x <= 0)
            {
                return n;
            }
            int i = 1;
            while (true)
            {
                int factorial = 1;
                for (int j = 1; j <= i; j++)
                {
                    factorial *= j;
                }

                if (factorial == x)
                {
                    n = i;
                    break;
                }
                else if (factorial > x)
                {
                    break;
                }

                i++;
            }

            return n;
        }
        
    }
}

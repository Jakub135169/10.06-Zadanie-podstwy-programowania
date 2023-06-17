using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._06._2023_zadanie_nr_2_pp
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("podaj jaka liczbę wyrazów ciągu Fibonnaciego mam Ci wyświetlić");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int ciąg = Fibonacciego(i);
                Console.WriteLine(ciąg);
               

            }
        }
        static int Fibonacciego(int n)
        {
            if (n <= 1)
                return n;

            return Fibonacciego(n - 1) + Fibonacciego(n - 2);

        }
    }
}

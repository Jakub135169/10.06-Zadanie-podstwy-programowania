using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _10._06.zadanie_nr1_pp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, wynik;
            Console.WriteLine("Podaj liczbę");
             a =  Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj stopień potęgi");
            b = Convert.ToDouble(Console.ReadLine());



            wynik = Math.Pow(a, b);
            Console.WriteLine($"wynik potęgowania jest równy={wynik}");
            Console.ReadLine();


        }
    }
}

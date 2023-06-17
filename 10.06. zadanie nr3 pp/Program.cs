using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._06.zadanie_nr3_pp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("podaj zmienną n ( większą lub równa=5)");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj zmienną k ( większą lub równa=5)");
           int k = int.Parse(Console.ReadLine());

            if (n<5 || k < 5)
            {
                Console.WriteLine("podano wartość mniejsza niż 5 " );
                Console.ReadLine ();
            }
            else
            {
                 
                {
                    double nSilnia = Silnia(n);
                    double kSilnia = Silnia(k);
                    

                    double m = (nSilnia - kSilnia) / kSilnia;
                    Console.WriteLine($"wynik to{m}");
                    Console.ReadLine();
                }

                 double Silnia(int liczba)
                {
                    if (liczba == 0)
                        return 1;

                    double m = 1;
                    for (int i = 1; i <= liczba; i++)
                    {
                        m *= i;
                    }

                    return m;

                }
            }
        }
    }
}

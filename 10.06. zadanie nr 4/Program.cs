using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._06.zadanie_nr_4
{
    internal class Program
    {

    //        Wczytaj kwotę początkową którą wpłacisz na konto oszczędnościowe, oprocentowanie
    //konta w skali roku, oraz liczbę miesięcy oszczędzania.Zakładając, że nie dodajesz
    //nowych środków, oraz że odsetki są naliczane co miesiąc(z oprocentowaniem równym
    //1/12 oprocentowania w skali roku), oblicz jaką kwotę zarobisz(uwzględnij tzw.
    //„podatek Belki”). 
        static void Main(string[] args)
 
        {
            Console.WriteLine("Podaj kwotę jaką wpłacasz na konto oszczędnościowe");
            double kwotaPoczatkowa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj oprocentowanie w skali roku (%):");
            double oprocentowanie = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj okres jaki planujesz oszczędzać (w msc)");
            int ilośćmsc = Convert.ToInt32(Console.ReadLine());

            double oprocentowanieMiesieczne = oprocentowanie / 12.0; 

            double kapital = kwotaPoczatkowa * (1 + oprocentowanieMiesieczne / 100); 

            for (int i = 2; i <= ilośćmsc; i++)
            {
                kapital += (kapital * oprocentowanieMiesieczne / 100); 
            }

            double podatekBelki = kapital * (19.0 / 100); 

            double kapitalPoOpodatkowaniu = kapital - podatekBelki; 

            Console.WriteLine("kwota oszczędności brutoo: " + kapitalPoOpodatkowaniu);
            Console.ReadLine();

        }
    }
}


    


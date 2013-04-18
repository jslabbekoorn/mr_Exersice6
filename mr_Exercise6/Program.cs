using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mr_Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {

            Klok klok = new Klok("Wit", "Vierkant", 10, 10);

            Console.WriteLine("De tijd is nu: " + klok.ToonUren12() + ":" + klok.ToonMinuten() + ":" + klok.ToonSeconden());
            Console.WriteLine(klok.KlokSlag());
            Console.WriteLine();

            klok.Instellen12Uur(5);
            klok.Instellen24Uur(5);
            klok.InstellenMinuut(20);
            klok.InstellenSeconde(20);

            Console.WriteLine("De tijd is nu: " + klok.ToonUren12() + ":" + klok.ToonMinuten() + ":" + klok.ToonSeconden());
            Console.WriteLine(klok.KlokSlag());
            Console.WriteLine();

            klok.Instellen12Uur(5);
            klok.Instellen24Uur(5);
            klok.InstellenMinuut(20);
            klok.InstellenSeconde(20);

            Console.WriteLine("De tijd is nu: " + klok.ToonUren12() + ":" + klok.ToonMinuten() + ":" + klok.ToonSeconden());
            Console.WriteLine(klok.KlokSlag());
            Console.WriteLine();

            klok.Instellen12Uur(5);
            klok.Instellen24Uur(5);
            klok.InstellenMinuut(20);
            klok.InstellenSeconde(20);

            Console.WriteLine("De tijd is nu: " + klok.ToonUren12() + ":" + klok.ToonMinuten() + ":" + klok.ToonSeconden());
            Console.WriteLine(klok.KlokSlag());
            Console.WriteLine();

            klok.Instellen12Uur(5);
            klok.Instellen24Uur(5);
            klok.InstellenMinuut(20);
            klok.InstellenSeconde(20);

            Console.WriteLine("De tijd is nu: " + klok.ToonUren12() + ":" + klok.ToonMinuten() + ":" + klok.ToonSeconden());
            Console.WriteLine(klok.KlokSlag());
            Console.WriteLine();

            klok.Instellen12Uur(5);
            klok.Instellen24Uur(5);
            klok.InstellenMinuut(20);
            klok.InstellenSeconde(20);

            Console.WriteLine("De tijd is nu: " + klok.ToonUren12() + ":" + klok.ToonMinuten() + ":" + klok.ToonSeconden());
            Console.WriteLine(klok.KlokSlag());
            Console.WriteLine();

            klok.Instellen12Uur(5);
            klok.Instellen24Uur(5);
            klok.InstellenMinuut(20);
            klok.InstellenSeconde(20);



            Console.ReadLine();





        }
    }
}

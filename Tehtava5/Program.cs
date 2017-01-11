using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava5
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodi1();

        }
        static void Metodi1()
        {
            Console.Write("Anna sekunnit > ");
            int Sekunnit = int.Parse(Console.ReadLine());

            var Sekuntti = TimeSpan.FromSeconds(Sekunnit);

            Console.WriteLine(string.Format("Antamasi sekuntiaika voidaan ilmaista muodossa: {0} tunti {1} minuutti {2} sekuntti", Sekuntti.Hours, Sekuntti.Minutes, Sekuntti.Seconds));
        }
    }
}

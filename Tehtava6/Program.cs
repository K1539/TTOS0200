using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava6
{
    class Program
    {
        static void Main(string[] args)
        {
            double KulutusKm = 0.0702;
            double BensanHintaLtr = 1.595;

            Console.Write("Anna matka > ");
            int KuljettuMatka = int.Parse(Console.ReadLine());
            double BensanKulutus = (KulutusKm * KuljettuMatka);
            Console.WriteLine("Bensaa kuluu {0:0.00} litraa, kustannus {1:0.00} euroa.", BensanKulutus, (BensanKulutus * BensanHintaLtr));
        }
    }
}

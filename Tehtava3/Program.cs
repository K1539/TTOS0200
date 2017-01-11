using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Luku1;
            int Luku2;
            int Luku3;
            Console.WriteLine("Kysyn Sinulta seuraavaksi 3 numeroa.");
            Console.Write("Anna ensimmainen luku > ");
            Luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen luku > ");
            Luku2 = int.Parse(Console.ReadLine());
            Console.Write("Anna kolmas luku > ");
            Luku3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lukujen summa = " + (Luku1 + Luku2 + Luku3));
            Console.WriteLine("Lukujen keskiarvo = " + ((Luku1 * Luku2 * Luku3) / 3));
        }
    }
}

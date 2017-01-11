using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Luvut = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Anna luku > ");
                Luvut[i] = int.Parse(Console.ReadLine());   
            }

            if (Luvut[0] > Luvut[1] && Luvut[0] > Luvut[2])
            {
                Console.WriteLine("Suurin Luku on " + Luvut[0]);
            }
            if (Luvut[1] > Luvut[0] && Luvut[1] > Luvut[2])
            {
                Console.WriteLine("Suurin Luku on " + Luvut[1]);
            }
            if (Luvut[2] > Luvut[0] && Luvut[2] > Luvut[1])
            {
                Console.WriteLine("Suurin Luku on " + Luvut[2]);
            }
        }
    }
}

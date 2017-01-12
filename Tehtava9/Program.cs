using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava9
{
    class Program
    {
        static void Main(string[] args)
        {
            int AnnettuLuku = 1;
            int[] Luvut = new int[9999];
            int j = 0;
            int SummaLuku = 0;

            while (AnnettuLuku != 0)
            {
                Console.Write("Anna luku > ");
                AnnettuLuku = int.Parse(Console.ReadLine());
                Luvut[j] = AnnettuLuku;
                j++;
            }
            for (int i = 0; i < j; i++)
            {
                SummaLuku = SummaLuku + Luvut[i];
            }
            Console.WriteLine("Lukujen summa on {0}", SummaLuku);
        }
    }
}

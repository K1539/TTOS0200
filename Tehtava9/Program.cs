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

            while (AnnettuLuku != 0)
            {
                Console.WriteLine("Anna luku > ");
                AnnettuLuku = int.Parse(Console.ReadLine());
            }
        }
    }
}

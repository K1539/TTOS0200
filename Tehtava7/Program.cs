using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna vuosi > ");
            int vuosi = int.Parse(Console.ReadLine());

            if ((vuosi % 4 == 0 && vuosi % 100 != 0) || (vuosi % 400 == 0))
            {
                Console.WriteLine("{0} on karkausvuosi", vuosi);
            }
            else
            {
                Console.WriteLine("{0} ei ole karkausvuosi.", vuosi);
            }
        }
    }
}

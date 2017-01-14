using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava20
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                int val;
                string[] valilyonti = { " " };
                int.TryParse(info.KeyChar.ToString(), out val);
                switch (val)
                {
                    case 1:
                        Console.Beep(260, 500);
                        break;
                    case 2:
                        Console.Beep(290, 500);
                        break;
                    case 3:
                        Console.Beep(320, 500);
                        break;
                    case 4:
                        Console.Beep(340, 500);
                        break;
                    case 5:
                        Console.Beep(380, 500);
                        break;
                    case 6:
                        Console.Beep(420, 500);
                        break;
                    case 7:
                        Console.Beep(470, 500);
                        break;
                    case 8:
                        Console.Beep(500, 500);
                        break;
                }
            }

            }
        }
    }


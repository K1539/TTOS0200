using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava20
{
    class Program
    {
        static void Main()
        {
            int TaulukkoKoko = 2;
            int SavelPaikka = 0;
            int Kosketin;
            int[] Savelma = new int[TaulukkoKoko];
            int C = 0, D = 1, E = 2, F = 3, G = 4, A = 5, H = 6, C2 = 7, h = 1;
            while (true)
            {
                
                ConsoleKeyInfo info = Console.ReadKey();
                int.TryParse(info.KeyChar.ToString(), out Kosketin);
                switch (Kosketin)
                {
                    case 1:
                        Console.Beep(260, 500);
                        Savelma = new int[TaulukkoKoko + h];
                        Savelma[SavelPaikka] = C;
                        h++;
                        break;
                    case 2:
                        Console.Beep(290, 500);
                        Savelma = new int[TaulukkoKoko + h];
                        Savelma[SavelPaikka] = D;
                        h++;
                        break;
                    case 3:
                        Console.Beep(320, 500);
                        Savelma = new int[TaulukkoKoko + h];
                        Savelma[SavelPaikka] = E;
                        h++;
                        break;
                    case 4:
                        Console.Beep(340, 500);
                        Savelma[SavelPaikka] = F;
                        break;
                    case 5:
                        Console.Beep(380, 500);
                        Savelma[SavelPaikka] = G;
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
                    case 0:
                        for (int i = 1; i < (Savelma.Length - 1); i++)
                        {
                            if (Savelma[i] == C)
                            {
                                Console.Beep(260, 500);
                            }
                            if (Savelma[i] == 1)
                            {
                                Console.Beep(290, 500);
                            }
                            if (Savelma[i] == 2)
                            {
                                Console.Beep(320, 500);
                            }
                            if (Savelma[i] == 3)
                            {
                                Console.Beep(340, 500);
                            }
                            if (Savelma[i] == G)
                            {
                                Console.Beep(380, 500);
                            }
                            if (Savelma[i] == A)
                            {
                                Console.Beep(420, 500);
                            }
                            if (Savelma[i] == H)
                            {
                                Console.Beep(470, 500);
                            }
                            if (Savelma[i] == C2)
                            {
                                Console.Beep(500, 500);
                            }


                        }
                     
                        break;
                }
                if (Kosketin == 9)
                {
                    TaulukkoKoko = 1;
                    SavelPaikka = 0;
                }
                SavelPaikka = SavelPaikka + 1;
            }

            }
        }
    }


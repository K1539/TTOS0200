/*
 * Kirjoita ohjelma, joka pyytää käyttäjältä opiskelijoiden arvosanat 0-5 ohjelmointi-opintojaksosta (voit itse päättää lopetusehdon). 
 * Tulosta arvosanajakauma käyttäen tähtimerkkejä seuraavasti:

Arvosanajakauma: 
0:
1:****
2:**
3:******
4:*****
5:**
 *
 * Jere Liikka 12.1.2017
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava14
{
    class Program
    {
        static void Main(string[] args)
        {
            int Nolla = 0, Yksi = 0, Kaksi = 0, Kolme = 0, Nelja = 0, Viisi = 0;
            string Syote;
            bool OnkoNumero;
            int Arvosana;

            Console.WriteLine("Syötä niin monta arvosanaa kuin haluat. \nKirjoita 'poistu' lopettaaksesi");
            
            while (true)
            {
                Console.Write("Syötä arvosana > ");
                Syote = Console.ReadLine();
                OnkoNumero = int.TryParse(Syote, out Arvosana);
                if (OnkoNumero == true)
                {

                    //
                    switch (Arvosana)
                    {
                        case 0:
                            Nolla++;
                            break;
                        case 1:
                            Yksi++;
                            break;
                        case 2:
                            Kaksi++;
                            break;
                        case 3:
                            Kolme++;
                            break;
                        case 4:
                            Nelja++;
                            break;
                        case 5:
                            Viisi++;
                            break;
                        default:
                            Console.WriteLine("Virheellinen syöttö!");
                            break;
                    }
                }
                if (Syote == "poistu")
                {
                    break;
                }

              }
            Console.WriteLine("Arvosanat: ");
            Console.Write("0: ");
            for (int i = 0; i < Nolla; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.Write("1: ");
            for (int i = 0; i < Yksi; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.Write("2: ");
            for (int i = 0; i < Kaksi; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.Write("3: ");
            for (int i = 0; i < Kolme; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.Write("4: ");
            for (int i = 0; i < Nelja; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.Write("5: ");
            for (int i = 0; i < Viisi; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        }
    }


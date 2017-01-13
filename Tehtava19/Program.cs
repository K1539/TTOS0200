using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava19
{

    class Program
    {

        static void Main(string[] args)
        {
            
            string ArvaaKirjain;
            string[] ArvatutKirjaimet = new string[99];
            int SananOikeus = 0;
            int VaariaVastauksia = 0, l = 0, PeliJatkuu = 0;
            Random ArvoSana = new Random();
            string[] SanaLista = { "tietokone", "auto", "volvo", "kalja" };
            string ArvottuSana = SanaLista[ArvoSana.Next(0, SanaLista.Length)];
            string[] SanaAlaviivoina = new string[ArvottuSana.Length];
            for (int i = 0; i < ArvottuSana.Length; i++)
            {
                if (ArvottuSana[i] == ' ')
                {
                    SanaAlaviivoina[i] = " ";
                }
                else
                {
                    SanaAlaviivoina[i] = "_";
                }
                Console.Write(SanaAlaviivoina[i]);
            }
            while (true)
            { 
                Console.WriteLine();
                Console.Write("Arvaa kirjain > ");

                ArvaaKirjain = Console.ReadLine();  //Tallennetaan arvattu kirjain

                for (var j = 0; j < ArvottuSana.Length; j++)
                {
                    if (ArvaaKirjain[0] == ArvottuSana[j])
                    {
                        SananOikeus++;
                    }
                }
                //Onko kirjain oikein. Jos on, kirjain sijoitetaan oikealle paikalle alaviivan sijaan
                if (SananOikeus > 0)
                {
                    Console.Write("{0} oikein!", ArvaaKirjain);
                    for (int i = 0; i < ArvottuSana.Length; i++)
                    {
                        if (ArvottuSana[i] == ArvaaKirjain[0])
                        {
                            SanaAlaviivoina[i] = ArvaaKirjain;
                        }
                    }
                }
                else
                {
                    Console.Write("Pieleen meni, arvaa uudelleen!");
                    VaariaVastauksia++;
                    Console.WriteLine();
                    Console.Write("Vaaria vastauksia : {0}/6", VaariaVastauksia);
                }
                Console.WriteLine();
                if (VaariaVastauksia == 6)
                {
                    Console.WriteLine("   -------\n   |     |\n   |     |\n   |     o\n   |    /|\\\n   |     |\n   |    / \\\n  ====\n  /   \\");
                }
                if (VaariaVastauksia == 5)
                {
                    Console.WriteLine("   -------\n   |     |\n   |     |\n   |     \n   |    \n   |     \n   |    \n  ====\n  /   \\");
                }
                if (VaariaVastauksia == 4)
                {
                    Console.WriteLine("   -------\n   |     \n   |     \n   |     \n   |    \n   |     \n   |    \n  ====\n  /   \\");
                }
                if (VaariaVastauksia == 3)
                {
                    Console.WriteLine("\n   |     \n   |     \n   |     \n   |    \n   |     \n   |    \n  ====\n  /   \\");
                }
                if (VaariaVastauksia == 2)
                {
                    Console.WriteLine("\n \n  \n  \n  \n   |     \n   |    \n  ====\n  /   \\");
                }
                if (VaariaVastauksia == 1)
                {
                    Console.WriteLine("\n \n \n \n \n \n \n  ====\n  /   \\");
                }
                Console.WriteLine();
                //tulostetaan, mitä tähän asti saatu arvattua(kirjaimet + alaviivat)
                for (int i = 0; i < ArvottuSana.Length; i++)
                {
                    Console.Write(SanaAlaviivoina[i]);
                }
                Console.WriteLine();
                //tulostetaan jo arvatut kirjaimet
                Console.WriteLine();
                ArvatutKirjaimet[l] = ArvaaKirjain;
                l++;
                Console.WriteLine(ArvaaKirjain);
                Console.Write("Arvatut kirjaimet: ");
                for (int i = 0; i < l; i++)
                {
                    Console.Write(ArvatutKirjaimet[i] + ", ");
                }
                //testataan, täsmääkö sanat
                for (int i = 0; i < ArvottuSana.Length; i++)
                {
                    if (ArvottuSana[0][i] = SanaAlaviivoina[i])
                    {
                        PeliJatkuu++;
                    }

                }

                Console.WriteLine();
                if (PeliJatkuu > 0)
                {
                    Console.WriteLine("Voitit pelin!");
                    break;
                }
                PeliJatkuu = 0;
            }
                }
            }
        }
 


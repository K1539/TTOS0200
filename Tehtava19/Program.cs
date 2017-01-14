using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava19
{

    class Program
    {

        static void Main()
        {

            var ArvaaKirjain = new char[99];
            var ArvatutKirjaimet = new char[99];
            int SananOikeus = 0, PeliLoppuu = 0, VaariaVastauksia = 0, l = 0, SanaOikein = 0;
            Random ArvoSana = new Random();
            string[] SanaLista = { "tietokone", "auto", "volvo", "kalja" };  //lista arvattavista sanoista
            string ArvottuSana = SanaLista[ArvoSana.Next(0, SanaLista.Length)];  //Arvotaan sana, käytetty random luokkaa
            var SanaAlaviivoina = new char[ArvottuSana.Length];
            for (int i = 0; i < ArvottuSana.Length; i++)
            {
                if (ArvottuSana[i] == ' ')
                {
                    SanaAlaviivoina[i] = ' ';
                }
                else
                {
                    SanaAlaviivoina[i] = '_';
                }
                Console.Write(SanaAlaviivoina[i]);
            }
            while (true)
            {

                Console.WriteLine();
                Console.Write("Arvaa kirjain > ");
                ArvaaKirjain[0] = Console.ReadKey().KeyChar;  //Tallennetaan arvattu kirjain

                for (var j = 0; j < ArvottuSana.Length; j++)
                {
                    if (ArvaaKirjain[0] == ArvottuSana[j])
                    {
                        SananOikeus++;
                    }
                }
                Console.Clear();
                //Onko kirjain oikein. Jos on, kirjain sijoitetaan oikealle paikalle alaviivan sijaan
                if (SananOikeus > 0)
                {
                    Console.WriteLine();
                    Console.Write("{0} oikein!", ArvaaKirjain[0]);
                    for (int i = 0; i < ArvottuSana.Length; i++)
                    {
                        if (ArvottuSana[i] == ArvaaKirjain[0])
                        {
                            SanaAlaviivoina[i] = ArvaaKirjain[0];
                        }
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.Write("Pieleen meni, arvaa uudelleen!");
                    VaariaVastauksia++;
                    Console.WriteLine();
                    Console.Write("Vaaria vastauksia : {0}/6", VaariaVastauksia);
                }
                //Tulostetaan hirsipuu
                Console.WriteLine();
                if (VaariaVastauksia == 6)
                {
                    Console.WriteLine("   -------\n   |     |\n   |     |\n   |     o\n   |    /|\\\n   |     |\n   |    / \\\n  ====\n  /   \\");
                    PeliLoppuu++;
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
                //tulostetaan jo arvatut kirjaimet, jokaisen kirjaimen perään pilkku listan luomiseksi
                Console.WriteLine();
                ArvatutKirjaimet[l] = ArvaaKirjain[0];
                l++;
                Console.WriteLine();
                Console.Write(" Arvatut kirjaimet: ");
                for (int i = 0; i < l; i++)
                {
                    Console.Write(ArvatutKirjaimet[i] + ", ");
                }
                //Jos PeliLoppuu > 1, peli päättyy, määritetään hirsipuun tulostuksen yhteydessä
                if (PeliLoppuu > 0)
                {
                    Console.WriteLine("Havisit pelin.");
                    break;
                }
                //Jos Arvattava sana ja Tähän asti arvattu täsmää, peli voitettu (jokainen character käydään läpi erikseen)
                Console.WriteLine();
                for (int i = 0; i < ArvottuSana.Length; i++)
                {
                    if (ArvottuSana[i] == SanaAlaviivoina[i])
                    {
                        SanaOikein++;
                    }
                    
                }
                Console.WriteLine();
                if (SanaOikein == (ArvottuSana.Length))
                {
                    Console.WriteLine("Voitit pelin!");
                    break;
                }
                SanaOikein = 0;
                SananOikeus = 0;

            }
        }
    }
}



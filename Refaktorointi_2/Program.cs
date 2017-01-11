using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// A simple example of Blackjack card game
/// </summary>
/// /*
/// Tee ohjelmaan muutos että käyttäjä voi pelata niin kauan kunnes hän antaa syötteeksi: X tai exit. 
/// Jos käyttäjä antaa jonkin muun merkkijonon joka ei ole kokonaisluku käyttäjälle näytetään ohje sallituista syötteistä.
/// */

namespace Refaktorointi
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber;
            int theirNumber;
            string UserInput;
            bool isNumeric;
            Random rnd = new Random();
            myNumber = rnd.Next(10, 21);
            while (true)
            {
                System.Console.WriteLine("*** BlackJack! ***");
                System.Console.Write("Can you beat my number? Enter any number between 1-21: ");
                //reading and converting 
                UserInput = System.Console.ReadLine();
                //comparing that given umber is valid
                isNumeric = int.TryParse(UserInput, out theirNumber);
                if (isNumeric == true)
                {
                    if (theirNumber < 1 || theirNumber > 21)
                    {
                        Console.WriteLine("The given number is out of limits, try again.");
                    }
                    else
                    {
                        //comparing
                        if (theirNumber >= myNumber && theirNumber <= 21)
                        {
                            System.Console.WriteLine("You win.");
                        }
                        else
                        {
                            System.Console.WriteLine("You lose.");
                        }
                    }
                }
                else if (UserInput == "X" || UserInput == "exit")
                {
                    break;
                }
                else
                {
                    Console.Write("Virheellinen Valinta!\n" +
                                "Ohjelmaan käy vain:\n" +
                                "\tnumerot 1-21\n" +
                                "\tX & exit ohjelmasta poistumiseen\n");
                }
            }
        }
    }
}

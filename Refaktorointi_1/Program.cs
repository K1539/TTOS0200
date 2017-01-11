using System;

            using System;
/// <summary>
/// A simple example of Blackjack card game
/// </summary>
/// /*
/// Muuta ohjelmaa että käyttäjältä kysytään lukua niin kauan että se on annetulta väliltä 
/// */
class BlackJack
        {
            static void Main()
            {
                int myNumber = 17;
                int theirNumber = 0;
                while (theirNumber < 1 || theirNumber > 21)
                {
                    System.Console.WriteLine("*** BlackJack! ***");
                    System.Console.Write("Can you beat my number? Enter any number between 1-21: ");
                    //reading and converting 
                    theirNumber = System.Convert.ToInt32(System.Console.ReadLine());
                    //comparing that given umber is valid
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
            }
        }
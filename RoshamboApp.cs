using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Roshambo
{
    class RoshamboApp
    {

        public static void playGame()
        {
           
                Console.WriteLine("Enter your name: ");
                string userName = Console.ReadLine();
                string userPlayer = PlayAgainst();

                int userWins = 0;
                int userLosses = 0;
                int draws = 0;

                do
                {

                    Console.WriteLine("\nPlease enter rock, paper, or scissors (R/P/S)");
                    string userWeapon = Console.ReadLine();

                    if (!Validator.CheckWeapon(userWeapon))
                    {
                        Console.WriteLine("invalid input...try again");
                        continue;
                    }

                    //USE VALIDATOR CLASS HERE FOR USER WEAPON!!!

                    Roshambo pcRosh = GetPcChoice(userPlayer);
                    Roshambo playerRosh = GetUserChoice(userWeapon);

                    Console.WriteLine($"{userName}: {playerRosh}");
                    Console.WriteLine($"{userPlayer.ToUpper()}: {pcRosh}");
                    Console.WriteLine();

                    var roshList = new Dictionary<Roshambo, string>
                {
                    //{userName, playerRosh},
                    //{userPlayer, pcRosh}

                    {playerRosh, userName },
                    {pcRosh, userPlayer }
                };

                    string winner;

                    if (roshList.ContainsKey(Roshambo.rock) && roshList.ContainsKey(Roshambo.scissors))
                    {
                        winner = roshList[Roshambo.rock];
                        Console.WriteLine($"{winner} wins");

                        //PUT BELOW INTO METHOD SINCE WE USE 3x
                        if (winner.Equals(userName))
                        {
                            userWins += 1;
                        }
                        else
                        {
                            userLosses += 1;
                        }

                    }
                    else if (roshList.ContainsKey(Roshambo.rock) && roshList.ContainsKey(Roshambo.paper))
                    {
                        winner = roshList[Roshambo.paper];
                        Console.WriteLine($"{winner} wins");

                        //PUT BELOW INTO METHOD SINCE WE USE 3x
                        if (winner.Equals(userName))
                        {
                            userWins += 1;
                        }
                        else
                        {
                            userLosses += 1;
                        }

                    }
                    else if (roshList.ContainsKey(Roshambo.paper) && roshList.ContainsKey(Roshambo.scissors))
                    {
                        winner = roshList[Roshambo.paper];
                        Console.WriteLine($"{winner} wins");

                        //PUT BELOW INTO METHOD SINCE WE USE 3x
                        if (winner.Equals(userName))
                        {
                            userWins += 1;
                        }
                        else
                        {
                            userLosses += 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Draw!");
                        draws += 1;
                    }

                    Console.WriteLine();

                    Console.WriteLine("Play again?(y/n)");
                    string userCont = Console.ReadLine();

                    if (userCont.Equals("n", StringComparison.OrdinalIgnoreCase))
                    {

                        Console.WriteLine($"\nYour wins: {userWins}");
                        Console.WriteLine($"Your losses: {userLosses}");
                        Console.WriteLine($"Your ties: {draws}");
                        Console.WriteLine("GOODBYE!");
                        break;
                    }

                } while (true);

      

        }

        public static string PlayAgainst()
        {
            do
            {
                Console.WriteLine("\nWho would you like to play against? (choose from below)");
                Console.WriteLine("Theresa (T)\nCandace (C)");
                string userPlayer = Console.ReadLine();

                if (!Validator.CheckPlayer(userPlayer))
                {
                    Console.WriteLine("invalid input. try again");


                }
                else
                {
                    return userPlayer;
                }

            } while (true);

            
        }
 
        public static Roshambo GetUserChoice(string userWeapon)
        {
            var playerRosh = new Roshambo();

            if (userWeapon.Equals("R", StringComparison.OrdinalIgnoreCase))
            {
                playerRosh = Roshambo.rock;
            }
            else if (userWeapon.Equals("P", StringComparison.OrdinalIgnoreCase))
            {
                playerRosh = Roshambo.paper;
            }
            else 
            {
                playerRosh = Roshambo.scissors;
            }

            return playerRosh;
        }

        public static Roshambo GetPcChoice(string player)
        {
            do { 

                if (player.Equals("T", StringComparison.OrdinalIgnoreCase))
                {
                    var playerOne = new Theresa();
                    var playerT = playerOne.GenerateRoshambo();
                    return playerT;
                }
                else
                {
                    var playerTwo = new Candace();
                    var playerC = playerTwo.GenerateRoshambo();
                    return playerC;
                }
    
            } while(true);


            

        }


    }
}

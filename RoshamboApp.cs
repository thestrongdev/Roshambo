using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    class RoshamboApp
    {
        
        public void playGame()
        {
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();

            Console.WriteLine("\nWho would you like to play against? (choose from below)");
            Console.WriteLine("Theresa\nCandace");
            string userPlayer = Console.ReadLine();

            //USE VALIDATOR CLASS HERE

            if (userPlayer == "Theresa")
            {
                var playerOne = new Theresa();

                var playerChoice = playerOne.GenerateRoshambo();

                Console.WriteLine(playerChoice);
            }
            else
            {
                var playerTwo = new Candace();

                var playerChoice = playerTwo.GenerateRoshambo();

                Console.WriteLine(playerChoice);
            }


            int userWins = 0;
            int userLosses = 0; 

            Console.WriteLine("\nPlease enter rock, paper, or scissors (R/P/S)");
            string userWeapon = Console.ReadLine();

            //USE VALIDATOR CLASS HERE

            Roshambo roshambo = new Roshambo();

            if (userWeapon.Equals("R", StringComparison.OrdinalIgnoreCase))
            {
                roshambo = (Roshambo)0;

                

            } else if (userWeapon.Equals("P", StringComparison.OrdinalIgnoreCase))
            {
                roshambo = (Roshambo)1;
            }
            else
            {
                roshambo = (Roshambo)2;
            }
            




            

        


        }

    }
}

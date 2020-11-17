using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    class Cheater 
    {
        //public override Roshambo GenerateRoshambo()
        //{
        //    return Roshambo.scissors; //will not use
        //}

        public static Roshambo Cheating(Roshambo userWeapon)
        {
            if(userWeapon == Roshambo.rock)
            {
                return Roshambo.paper;

            } else if (userWeapon == Roshambo.scissors)
            {
                return Roshambo.rock;
            }
            else
            {
                return Roshambo.scissors;
            }
        }
    }
}

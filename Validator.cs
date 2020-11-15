using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    class Validator
    {
        public static bool CheckPlayer(string userPlayer)
        {
            if (!userPlayer.Equals("c", StringComparison.OrdinalIgnoreCase) && !userPlayer.Equals("t", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool CheckWeapon(string userWeapon)
        {
            if (!userWeapon.Equals("r", StringComparison.OrdinalIgnoreCase) && !userWeapon.Equals("p", StringComparison.OrdinalIgnoreCase)
                && !userWeapon.Equals("s", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
            else
            {
                return true;
            }
        
        }

    }
}

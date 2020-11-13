using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    class Candace : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            Random roshambo = new Random();

            Roshambo value = (Roshambo)roshambo.Next(0, 2);

            return value;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    class James : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.paper;
        }
    }
}

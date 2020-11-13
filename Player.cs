using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    public abstract class Player
    {
        public string name { get; set; }
        public Roshambo roshambo { get; set; }

        public abstract Roshambo GenerateRoshambo();
      
    }
}

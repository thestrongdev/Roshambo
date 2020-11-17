using System;
using System.Linq;
using System.Collections.Generic;

namespace Roshambo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RoshamboApp.PlayGame();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}

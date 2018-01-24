using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptLib
{
    public static class TheSourceCode
    {
        static Random R1 = new Random();
        public static string RandoErrorMessageOpener()
        {
            int rInt = R1.Next(0, 100);
            if (rInt < 20)
            {
                return ("TITANIC DISASTER! Your code just ice berged you:");
            }
            else if (rInt < 40)
            {
                return ("DEEP STATE COUP. Program hijacked by government forces loyal to the illuminati: ");
            }
            else if (rInt < 60)
            {
                return ("NORTH KOREAN ICBM INCOMING! ");
            }
            else if (rInt < 80)
            {
                return ("This s*** is f*****: ");
            }
            else
            {
                return ("WTF?!? ");
            }
        }
    }
}

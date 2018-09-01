using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizsample1
{
    public static class Globals
    {
       
        static Globals() { Score = 0; } // default value

        // public get, and private set for strict access control
        public static int Score { get; private set; }
        public static int show { get; private set; }

        // GlobalInt can be changed only via this method
        public static void SetScore(int newInt)
        {
           Score = newInt;
        }

    }
}

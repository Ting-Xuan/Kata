using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExesAndOhs
{
    public class Kata
    {
        public static bool XO(string str)
        {
            return (OXNum(str, 'O') == OXNum(str, 'X'));
        }

        public static int OXNum(string input, char text)
        {
            int rNum = 0;
            input = input.ToUpper();
            rNum = input.ToCharArray().Where(x => x == text).ToList().Count;

            return rNum;
        }

    }
}

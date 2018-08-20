using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCypher
{
    public class Kata
    {

        public static int[] Encode(string sInput, int keyNum)
        {
            char[] cInput = sInput.ToCharArray();
            int[] eRst = new int[cInput.Length];
            var ekynumArray = keyNum.ToString().ToArray();
            for (int i = 0; i < cInput.Length; i++)
            {
                eRst[i] = AlphabetToInt(cInput[i]) + Int16.Parse(ekynumArray[i % ekynumArray.Length].ToString());
            }

            return eRst;
        }


        public static int AlphabetToInt(char alphbet)
        {

            return (Convert.ToInt32(char.ToUpper(alphbet)) - 64);
        }



    }
}

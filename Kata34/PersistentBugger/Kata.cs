using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistentBugger
{
    public class Kata
    {
        public static int PersistenceBugger(long n)
        {
            var nums = n.ToString().ToCharArray();
            var times = 0;

            while (nums.Length>1)
            {
                var mNum = nums.Aggregate<char, long>(1, func: (current, t) => current * (int) Char.GetNumericValue(t));

                times++;

                nums = mNum.ToString().ToCharArray();
            }
           
            return times;
        }


    }
}

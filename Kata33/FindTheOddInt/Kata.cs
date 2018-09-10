using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FindTheOddInt
{
    public class Kata
    {
        public static int FindOndInt(int[] nums)
        {
            var num1 = nums.OrderBy(g=>g).Distinct().ToArray();

            var oCs = num1.Select(t => new OddCount
                {
                    Num = t,
                    Count = nums.Count(x => x == t)
                })
                .ToList();

            int oCs_Count = oCs.Count(x => x.Count % 2 == 1);
            if (oCs_Count > 1 || oCs_Count < 1)
            {
                return 0;
            }
            else
            {
                return oCs.Where(x => x.Count % 2 == 1).Select(g => g.Num).FirstOrDefault();
            }

        }

        public class OddCount
        {
            public int Num { set; get; }
            public int Count { set; get; }
        }

        

    }
}

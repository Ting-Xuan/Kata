using System.Linq;

namespace OnlyOne
{
    public class Kata38
    {
        public bool OnlyOne(params bool[] flags)
        {
            return flags.Count(x => x == true) == 1;
        }
    }
}
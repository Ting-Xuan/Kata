using System.Linq;

namespace ArrayMath
{
    public class Kata39
    {
        public int Product(int[] values)
        {
            return values.Aggregate((current, number) => current * number);
        }
    }
}
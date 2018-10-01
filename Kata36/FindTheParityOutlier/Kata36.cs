using System.Linq;

namespace FindTheParityOutlier
{
    public class Kata36
    {
        public int FindTheParityOutlier(int[] numbers)
        {
            var even = numbers.Count(x => x % 2 == 0) < 2 ? numbers.FirstOrDefault(x => x % 2 == 0) : 0;
            var odd = numbers.Count(x => x % 2 != 0) < 2 ? numbers.FirstOrDefault(x => x % 2 != 0) : 0;

            return odd == 0 ? even : odd;
        }
    }
}
using System;
using System.Linq;

namespace SumofDigits
{
    public class Kata37
    {
        public int SumofDigits(int input)
        {
            var output = 0;
            output = input < 10 ? input : Calculate(IntegerToCharArray(input), output);

            return output;
        }

        private int Calculate(char[] numbers, int output)
        {
            while (numbers.Length > 1)
            {
                output = numbers.Sum(number => int.Parse(number.ToString()));
                numbers = IntegerToCharArray(output);
            }

            return output;
        }

        private char[] IntegerToCharArray(int output)
        {
            return output.ToString().ToCharArray();
        }
    }
}
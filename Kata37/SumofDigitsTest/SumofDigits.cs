using NUnit.Framework;
using SumofDigits;
using Assert = NUnit.Framework.Assert;

namespace SumofDigitsTest
{
    public class SumofDigits
    {
        private Kata37 _digits;

        [SetUp]
        public void SetUp()
        {
            _digits = new Kata37();
        }

        [TestCase(0, 0)]
        public void DigitInZero(int input, int output)
        {
            Assert.AreEqual(output, _digits.SumofDigits(input));
        }

        [TestCase(1, 1)]
        [TestCase(6, 6)]
        public void DigitInOne(int input, int output)
        {
            Assert.AreEqual(output, _digits.SumofDigits(input));
        }

        [TestCase(16, 7)]
        public void DigitInTens(int input, int output)
        {
            Assert.AreEqual(output, _digits.SumofDigits(input));
        }

        [TestCase(111, 3)]
        [TestCase(942, 6)]
        [TestCase(999, 9)]
        public void DigitInHundred(int input, int output)
        {
            Assert.AreEqual(output, _digits.SumofDigits(input));
        }

        [TestCase(1111, 4)]
        [TestCase(1321, 7)]
        [TestCase(9999, 9)]
        public void DigitInThousand(int input, int output)
        {
            Assert.AreEqual(output, _digits.SumofDigits(input));
        }

        [TestCase(132189, 6)]
        [TestCase(493193, 2)]
        public void Digits(int input, int output)
        {
            Assert.AreEqual(output, _digits.SumofDigits(input));
        }
    }
}
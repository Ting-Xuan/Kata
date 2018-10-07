using NUnit.Framework;
using OnlyOne;

namespace OnlyOneTest
{
    public class OnlyOne
    {
        public Kata38 _onlyOne;

        [SetUp]
        public void SetUp()
        {
            _onlyOne = new Kata38();
        }

        [TestCase(true, true)]
        [TestCase(true, false, true)]
        [TestCase(true, false, false, true)]
        public void ExceptTrue(bool except, params bool[] input)
        {
            Assert.AreEqual(except, _onlyOne.OnlyOne(input));
        }

        [TestCase(false, false)]
        [TestCase(false, true, true)]
        [TestCase(false, false, false, false, false)]
        public void ExceptFalse(bool except, params bool[] input)
        {
            Assert.AreEqual(except, _onlyOne.OnlyOne(input));
        }
    }
}
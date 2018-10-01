using FindTheParityOutlier;
using NUnit.Framework;

namespace FindTheParityOutlierTest
{
    [TestFixture]
    public class FindTheParityOutlier
    {
        private Kata36 _kata36;

        [SetUp]
        public void Setup()
        {
            _kata36 = new Kata36();
        }

        [TestCase(11, new int[] { 2, 4, 0, 100, 4, 11, 2602, 36 })]
        [TestCase(7, new int[] { 6, 6, 0, 2, 7, 80 })]
        [TestCase(1, new int[] { 1, 0, 0 })]
        [TestCase(-1, new int[] { -1 })]
        public void OddNumber(int Exp, int[] Numbers)
        {
            Assert.AreEqual(Exp, _kata36.FindTheParityOutlier(Numbers));
        }

        [TestCase(160, new int[] { 160, 3, 1719, 19, 11, 13, -21 })]
        [TestCase(6, new int[] { 6, 9, 1, 15, 21 })]
        [TestCase(0, new int[] { 1, 0, 1 })]
        [TestCase(-2, new int[] { -2, 9, 1 })]
        public void EvenNumber(int Exp, int[] Numbers)
        {
            Assert.AreEqual(Exp, _kata36.FindTheParityOutlier(Numbers));
        }
    }
}
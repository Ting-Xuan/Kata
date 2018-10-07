using ArrayMath;
using NUnit.Framework;
using System;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace ProductTests
{
    public class ProductTests
    {
        public Kata39 ArrayMath;

        [SetUp]
        public void SetUp()
        {
            ArrayMath = new Kata39();
        }

        [TestCase(540, new int[] { 5, 4, 1, 3, 9 })]
        [TestCase(-1, new int[] { -1, 1 })]
        [TestCase(10, new int[] { 10 })]
        [TestCase(0, new int[] { 0, 2, 9, 7 })]
        [TestCase(-672, new int[] { -2, 6, 7, 8 })]
        [TestCase(540, new int[] { 5, 4, 1, 3, 9 })]
        public void BasicTests(int except, int[] input)
        {
            Assert.AreEqual(except, ArrayMath.Product(input));
        }

        [Test]
        public void ArgumentNullTest()
        {
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                ArrayMath.Product(null);
            });
        }

        [Test]
        public void InvalidOperationTest()
        {
            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                ArrayMath.Product(new int[] { });
            });
        }
    }
}
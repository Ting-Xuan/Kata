using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindTheOddInt;
namespace FindTheOddIntTest
{
    [TestClass]
    public class FindTheOddIntTest
    {
        [TestMethod]
        public void OnlyOneOddInterger()
        {
            Assert.AreEqual(5, Kata.FindOndInt(new [] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
        }

        [TestMethod]
        public void NoOddInterger()
        {
            Assert.AreEqual(0, Kata.FindOndInt(new[] {1, 1, 2, 2, 3, 3}));
        }
    }
}

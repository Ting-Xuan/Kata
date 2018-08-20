using System;
using DigitalCypher;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExpectedObjects;

namespace DigitalCypherTest
{
    [TestClass]
    public class CypherTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            CollectionAssert.AreEqual(new int[] { 20, 12, 18, 30, 21 }, Kata.Encode("scout", 1939));
            CollectionAssert.AreEqual(new int[] { 14, 10, 22, 29, 6, 27, 19, 18, 6, 12, 8 }, Kata.Encode("masterpiece", 1939));
        }
    }
}

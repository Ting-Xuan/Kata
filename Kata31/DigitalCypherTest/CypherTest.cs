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
        public void SecretKeyLength_Four()
        {
            CollectionAssert.AreEqual(new int[] { 20, 12, 18, 30, 21 }, Kata.Encode("scout", 1939));
            CollectionAssert.AreEqual(new int[] { 14, 10, 22, 29, 6, 27, 19, 18, 6, 12, 8 }, Kata.Encode("masterpiece", 1939));
        }

        public void SecretKeyLength_Ten()
        {
            CollectionAssert.AreEqual(new int[] { 20, 12, 18, 30, 2 }, Kata.Encode("scout", 1939246802));
            CollectionAssert.AreEqual(new int[] { 14, 10, 22, 29, 7, 22, 22, 17, 5, 5, 6 }, Kata.Encode("masterpiece", 1939246802));
        }


        [TestMethod]
        public void SecretKeyIsZero()
        {
            CollectionAssert.AreEqual(new int[] {19, 3, 15, 21, 20}, Kata.Encode("scout", 0));
        }


        [TestMethod]
        public void SecretKeyNegativeNum()
        {
            CollectionAssert.AreEqual(null, Kata.Encode("scout", -1));
        }
    }
}

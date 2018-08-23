using System;
using ExesAndOhs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ExesAndOhsTest
{
    [TestClass]
    public class ExesAndOhsTest
    {
        [TestMethod]
        public void OOXXTest()
        {
            Assert.AreEqual(true, Kata.XO("OOXX"));
        }


        [TestMethod]
        public void xooxxTest()
        {
            Assert.AreEqual(false, Kata.XO("xooxx"));
        }

        [TestMethod]
        public void OOXXMTest()
        {
            Assert.AreEqual(true, Kata.XO("OOXXM"));
        }

        [TestMethod]
        public void zpzpzppTest()
        {
            Assert.AreEqual(true, Kata.XO("zpzpzpp"));
        }

        [TestMethod]
        public void zzooTest()
        {
            Assert.AreEqual(false, Kata.XO("zzoo"));
        }


        [TestMethod]
        public void OTest()
        {
            Assert.AreEqual(false, Kata.XO("O"));
        }



        [TestMethod]
        public void OaTfuxTest()
        {
            Assert.AreEqual(true, Kata.XO("OaTfux"));
        }

    }
}

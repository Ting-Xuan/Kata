using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersistentBugger;
namespace PersistentBuggerTest
{
    [TestClass]
    public class PersistTests
    {
        [TestMethod]
        public void TensDigitals()
        {
            Assert.AreEqual(3, Kata.PersistenceBugger(39));
        }

        [TestMethod]
        public void Tens2Digits()
        {
            Assert.AreEqual(2, Kata.PersistenceBugger(25));
        }

        [TestMethod]
        public void OnesDigits()
        {
            Assert.AreEqual(0, Kata.PersistenceBugger(4));
        }

        [TestMethod]
        public void ZeorDigits()
        {
            Assert.AreEqual(0, Kata.PersistenceBugger(0));
        }

        [TestMethod]
        public void HundredsDigital()
        {
            Assert.AreEqual(4, Kata.PersistenceBugger(999));
        }


        [TestMethod]
        public void MoreOneDigits()
        {
            Assert.AreEqual(1, Kata.PersistenceBugger(1111111111111111111));
        }

        [TestMethod]
        public void More9Digits()
        {
            Assert.AreEqual(2, Kata.PersistenceBugger(9999999999999999));
        }
    }
}

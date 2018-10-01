using System;
using NUnit.Framework;
using VowelCount;
using Assert = NUnit.Framework.Assert;
namespace VowelCountTest
{
    [TestFixture]
    public class VowelCount
    {
        public Kata35 Vowel;

        [SetUp]
        public void Setup()
        {
            Vowel = new Kata35();
        }
        [TestCase(5, "abracadabra")]
        [TestCase(5, "aeiou")]
        [TestCase(5, "a e i o u")]
        public void Have5Vowels(int Exp, string str)
        {
            Assert.AreEqual(Exp, Vowel.GetVowelCount(str));
        }

    
        [TestCase(0,"")]
        [TestCase(0, "        ")]
        public void VowelCase_NoWordOrSpace(int Exp, string str)
        {
            Assert.AreEqual(Exp, Vowel.GetVowelCount(str));
        }

        [TestCase(0, "AEIOU")]
        public void VowelCase_UpperVowel(int Exp, string str)
        {
            Assert.AreEqual(Exp, Vowel.GetVowelCount(str));
        }

    }

    
}

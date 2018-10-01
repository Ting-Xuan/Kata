using System.Collections.Generic;
using System.Linq;

namespace VowelCount
{
    public class Kata35
    {
        public int GetVowelCount(string str)
        {
            var vowelCount = 0;
            var vowels = new List<char>(new List<char>()
                { 'a','e','i','o','u'});
            var strArray = StrToCharArray(str);
            foreach (var vowel in vowels)
            {
                vowelCount += strArray.Where(x => x == vowel).ToList().Count();
            }
            return vowelCount;
        }

        private char[] StrToCharArray(string str)
        {
            return str.ToArray();
        }
    }
}
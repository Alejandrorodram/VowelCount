using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace VowelCount
{
    internal class Kata
    {
        public static int GetVowelCount1(string str)
        {
            return str.Count(i => "aeiou".Contains(i));
        }

        public static int GetVowelCount2(string str)
        {
            return str.ToLower().Count(c => "aeiou".IndexOf(c) != -1);
        }

        public static int GetVowelCount3(string str)
        {
            return (Regex.Matches(str, @"[aeiouAEIOU]")).Count;
        }
    }
}

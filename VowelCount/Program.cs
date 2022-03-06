using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.GetVowelCount1("Contar las vocales de este texto"));
            Console.WriteLine(Kata.GetVowelCount2("Contar las vocales de este texto"));
            Console.WriteLine(Kata.GetVowelCount3("Contar las vocales de este texto"));

        }
    }
}

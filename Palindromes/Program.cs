using System;
using System.Linq;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = "calvin d!,22  test!";
            var test2 = test.Reverse();
            foreach(var letter in test2)
            {
                if (Char.IsLetter(letter))
                {
                Console.WriteLine(letter);

                }
            }
        }
    }
}

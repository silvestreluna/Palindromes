using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindromes
{
    public class PalindromeChecker
    {
        public bool IsPalidrome(string wordToCheck)
        {
            var wordToCheckToChar = wordToCheck.ToCharArray();
            var tempWord = wordToCheck.Reverse();

            var wordToCheckWithoutChar = "";
            var reversedWord = "";

            foreach (var eachLetter in tempWord)
            {
                if (char.IsLetter(eachLetter))
                {
                    reversedWord += eachLetter;
                }
            }

            foreach(var eachChar in wordToCheckToChar)
            {
                if(char.IsLetter(eachChar))
                {
                    var eachCharToString = eachChar.ToString();
                    wordToCheckWithoutChar += eachCharToString;
                }
            }

            if (reversedWord.ToLower() == wordToCheckWithoutChar.ToLower())
            {
                return true;

            } else return false;
        }

    }

}

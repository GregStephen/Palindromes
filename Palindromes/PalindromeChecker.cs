using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindromes
{
    public class PalindromeChecker
    {
        string Reverse(string wordToReverse)
        {
            char[] charArray = wordToReverse.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public bool Check(string word)
        {
            var formattedWord = new string(word.Where(c => !char.IsPunctuation(c)).ToArray()).ToLower();
            var noSpacesWord = string.Join("",formattedWord.Split(" "));
            var reversedWord = Reverse(noSpacesWord);

            return (reversedWord == noSpacesWord);
        }
    }
}

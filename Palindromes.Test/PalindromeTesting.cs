using System;
using Xunit;

namespace Palindromes.Test
{
    public class PalindromeTesting
    {
        [Fact]
        public void StarsIsNotAPalindrome()
        {
            var word = "Stars";
            var palindromeChecker = new PalindromeChecker();

            var result = palindromeChecker.Check(word);

            Assert.False(result);
        }

        [Fact]
        public void SpacesAndSymbolsShouldNotMatter()
        {
            var word = "O, a kak Uwakov lil vo kawu kakao!";
            var palindromeChecker = new PalindromeChecker();

            var result = palindromeChecker.Check(word);

            Assert.True(result);
        }

        [Fact]
        public void ThirdTestForAssurance()
        {
            var word = "Some men interpret nine memos";
            var palindromeChecker = new PalindromeChecker();

            var result = palindromeChecker.Check(word);

            Assert.True(result);
        }
    }
}

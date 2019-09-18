using System;
using Xunit;

namespace Palindromes.Test
{
    public class PalindromesTest
    {
        [Fact]
        public void CheckIfGivenStringIsAPalindrome()
        {
            // Arrange
            var givenString = "stars";
            var palindromeChecker = new PalindromeChecker();

            //Act 
            var result = palindromeChecker.IsPalidrome(givenString);

            // Assert

            Assert.False(result);

        }

        [Fact]
        public void CheckIfGivenStringWithCharIsAPalindrome()
        {
            // Arrange
            var givenString = "O, a kak Uwakov lil vo kawu kakao!";
            var palindromeChecker = new PalindromeChecker();

            //ACT
            var result = palindromeChecker.IsPalidrome(givenString);

            // Assert

            Assert.True(result);
        }
    }
}

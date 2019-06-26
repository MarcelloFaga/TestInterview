using BusinessCode;
using NUnit.Framework;

namespace Tests
{
    public class PalindromeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("abba", true)]
        [TestCase("circo", false)]
        [TestCase("bbaa", true)]
        [TestCase("zaa", true)]
        [TestCase("z", true)]
        [TestCase("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaabbbccccaaaaaaaaaaaaa", false)]
        [TestCase("zyyzzzzz", true)]
        public void ShouldCheckIfGivenStringCanBeAPalindrome(string text, bool expected)
        {
            var palindromeBuilder = new PalindromeBuilder();

            bool canBePalindrome = palindromeBuilder.Process(text);

            Assert.That(canBePalindrome, Is.EqualTo(expected));
        }
    }
}
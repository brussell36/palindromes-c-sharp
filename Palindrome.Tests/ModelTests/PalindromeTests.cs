using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeFinder;

namespace PalindromeFinder.Tests
{
  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void IsPalindrome_WordIsPalindrome_True()
    {
      Palindrome testPalindrome = new Palindrome();
      Assert.AreEqual("Palindrome!", testPalindrome.IsPalindrome("racecar"));
    }
  }
}
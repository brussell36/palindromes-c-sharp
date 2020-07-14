using System;
using System.Linq;

namespace PalindromeFinder
{
  public class Palindrome
  {
    public string IsPalindrome(string input)
    {
      char[] inputArray = input.ToCharArray();
      char[] reverseArray = input.ToCharArray();
      Array.Reverse(reverseArray);
      if(inputArray.SequenceEqual(reverseArray))
      {
        return "Palindrome!";
      }
      else
      {
        return "Not a palindrome!";
      }
    }
  }
}
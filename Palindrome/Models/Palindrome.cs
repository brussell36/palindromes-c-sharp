using System;
using System.Linq;

namespace PalindromeFinder
{
  public class Palindrome
  {
    public string IsPalindrome(string input)
    {
      char[] inputArray = input.ToCharArray();
      /*  char[] reverseArray = input.ToCharArray();
        Array.Reverse(reverseArray); */
      int end = inputArray.Length - 1;
      for(int start = 0; start < Math.Floor(Convert.ToDouble(inputArray.Length / 2)); start++)
      {
        Console.WriteLine(inputArray[start]);
        Console.WriteLine(inputArray[end]);
        if(inputArray[start] != inputArray[end])
        {
          return "Not a palindrome!";
        } 
        else
        {
          end--;
          continue;
        }
      }
      return "Palindrome!";
    }
  }
}
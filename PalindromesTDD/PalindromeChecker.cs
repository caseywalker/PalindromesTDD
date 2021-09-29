using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromesTDD
{
  public class PalindromeChecker
  {

    public bool CheckPalindrome(string palindrome)
    {

      var palindromeArr = palindrome.ToCharArray();
      var convertedLower = palindromeArr.Select(c => Char.ToLower(c));

      var reversedPalindrome = palindromeArr.Reverse().ToArray();
      var convertedLowerReverse = reversedPalindrome.Select(c => Char.ToLower(c));

      return convertedLower.SequenceEqual(convertedLowerReverse);
    }
  }
}

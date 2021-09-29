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
      var palindromeWithoutSpace = convertedLower.Where(a => a != ' ');
      var palindromeWithoutComma = palindromeWithoutSpace.Where(a => a != ',');
      var palindromeWithoutQuestion = palindromeWithoutComma.Where(a => a != '?');
      var palindromeWithoutExc = palindromeWithoutQuestion.Where(a => a != '!');
      var palindromeWithoutapos = palindromeWithoutExc.Where(a => a != '\'');

      var reversedPalindrome = palindromeArr.Reverse().ToArray();
      var convertedLowerReverse = reversedPalindrome.Select(c => Char.ToLower(c));
      var reversedWithoutSpace = convertedLowerReverse.Where(a => a != ' ');
      var reversedWithoutComma = reversedWithoutSpace.Where(a => a != ',');
      var reversedWithoutQuestion = reversedWithoutComma.Where(a => a != '?');
      var reversedWithoutExc = reversedWithoutQuestion.Where(a => a != '!');
      var reversedWithoutapos = reversedWithoutExc.Where(a => a != '\'');

      return palindromeWithoutapos.SequenceEqual(reversedWithoutapos);
    }
  }
}

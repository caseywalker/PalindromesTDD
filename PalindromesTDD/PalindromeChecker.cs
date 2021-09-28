using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromesTDD
{
  class PalindromeChecker
  {

    public bool CheckPalindrome(string palindrome)
    {
      var reversed = palindrome.Reverse().ToString();

      if (reversed == palindrome)
      {
        return true;
      }
      else return false;
    }
  }
}

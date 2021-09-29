using System;
using Xunit;

namespace PalindromesTDD.Tests
{
  public class UnitTest1
  {
    [Fact]
    public void Test1()
    {
      //Arrange
      var stringToTest = "Stats";
      var checker = new PalindromeChecker();

      //Act
      bool actualResult = checker.CheckPalindrome(stringToTest);

      //Assert
      Assert.True(actualResult);

    }

    [Theory]
    [InlineData("Stats")]
    [InlineData("Amore, Roma")]
    [InlineData("No 'x' in Nixon")]
    [InlineData("Was it a cat I saw?")]
    [InlineData("O, a kak Uwakov lil vo kawu kakao!")]
    [InlineData("Some men interpret nine memos")]
    public void test_for_palindrome(string stringToTest)
    {
      //Arrange
      var checker = new PalindromeChecker();

      //Act
      bool actualResult = checker.CheckPalindrome(stringToTest);

      //Assert
      Assert.True(actualResult);
    }
  }
}

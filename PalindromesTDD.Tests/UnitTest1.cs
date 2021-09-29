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
  }
}

using Xunit;
using System;
namespace WordCounter
{
  public class WordcounterTests
  {
    [Fact]
    public void Test01_GetUserInput_ReturnsTrue()
    {
      //Arrange
      WordCounter nextWord = new WordCounter("hello world");
      //Act
      string result = nextWord.GetUserInput();
      //Assert
      Assert.Equal("hello world", result); //Should now return positive as the strings are equal.
    }

    [Fact]
    public void Test02_GetUserInput_ReturnsTrue()
    {
      //Arrange
      WordCounter nextWord = new WordCounter("my, my, my, welcome, welcome, welcome, to the land of Expectations.");
      //Act
      string result = nextWord.GetUserInput();
      //Assert
      Assert.Equal("My, My, My, welcome, welcome, welcome, to the land of Expectation", result); //Should fail at first, as the string that is passed through the method is
                                                                                         //not identical to the string that we are Asserting it to.
    }
  }
}

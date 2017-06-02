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
      //ACT
      string result = nextWord.GetUserInput();
      //Assert
      Assert.Equal("hello", result);
    }
  }
}

using Xunit;
using System;

namespace WordCounter
{
  public class WordRepeatCounterTests
  {
    // [Fact]
    // public void Test01_GetUserInputPhrase_ReturnsTrue()
    // {
      //Arrange
      //WordRepeatCounter nextWord = new WordRepeatCounter("hello world");
      //Act
      //   string result = nextWord.GetUserInputPhrase();
      //   //Assert
      //   Assert.Equal("hello world", result); //Should now return positive as the strings are equal.
      // }
      // //Another one just for fun.
      // [Fact]
      // public void Test02_GetUserInputPhrase_ReturnsTrue()
      // {
      //   //Arrange
      //   WordRepeatCounter nextWord = new WordRepeatCounter("My, My, My, welcome, welcome, welcome, to the land of Expectations.");
      //   //Act
      //   string result = nextWord.GetUserInputPhrase();
      //   //Assert
      //   Assert.Equal("My, My, My, welcome, welcome, welcome, to the land of Expectations.", result); //Should fail at first, as the string that is passed through the method is
      //
                                                                                       //not identical to the string that we are Asserting it to.

      [Fact]
      public void Test01_GetUserInputPhrase_ReturnsTrue()
      {
      //Arrange
      WordRepeatCounter newRepeatedWord = new WordRepeatCounter("kittensNomNom", "kittensNomNom");
      //Act
      string comparison01 = newRepeatedWord.GetUserInputPhrase();
      string comparison02 = newRepeatedWord.GetUsersWord();
      //Assert
      Assert.Equal("kittensNomNom", comparison01);
      Assert.Equal("kittensNomNom", comparison02);
    }
  }
}

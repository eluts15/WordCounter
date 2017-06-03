using Xunit;
using System;

namespace WordCounter
{
  public class WordRepeatCounterTests
  {

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

      [Fact]
      public void Test02_GetFrequencyOfSpecifiedWord_ReturnsTrue()
      {
        //Arrange
        WordRepeatCounter newRepeatedWord = new WordRepeatCounter("my my my my welcome welcome welcome, to the land of Expectations!", "my"); //Now it will pass because letter casing is the same.
        //Assert
        Assert.Equal(4, newRepeatedWord.ObtainFrequency());
      }

      [Fact]
      public void Test03_GetFrequencyOfSpecifiedWordIfEmpty_ReturnsTrue()
      {
        //Arrange
        WordRepeatCounter newRepeatedWord = new WordRepeatCounter("", "");
        Assert.Equal(0, newRepeatedWord.ObtainFrequency());
      }
  }
}

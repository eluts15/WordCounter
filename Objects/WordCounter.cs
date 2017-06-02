using System;

namespace WordCounter
{
  public class WordRepeatCounter
  {
    //WordCounter class composed of word objects
    private string _getPhrase;
    private string _word;

    public WordRepeatCounter(string phrase, string word) //Constructor
    {
      _getPhrase = phrase;
      _word = word;
    }

    //Getters and Setters
    public string GetUserInputPhrase()
    {
      return _getPhrase;
    }

    public void SetUserInputPhrase(string newPhrase)
    {
      _getPhrase = newPhrase;
    }

    public string GetUsersWord()
    {
      return _word;
    }

    public void SetUsersWord(string newWord)
    {
      _word = newWord;
    }
  }
}

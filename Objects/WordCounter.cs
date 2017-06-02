using System;

//TODO Explore Regex to remove all punctuation as punctuation should not be considered as words.

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

    public int ObtainFrequency()
    {
      string userWord = this.GetUsersWord(); //Store users word as a string.
      string[] userPhrase = this.GetUserInputPhrase().Split(' '); //Use spaces as delimiter to create an array of words. //Dont forget ' ' vs " "
      int frequency = 0;

      foreach (string word in userPhrase)
      {
        if (userWord == word) //In the case that a match is found, increment frequency by 1.
        {
          frequency++;
        }
      }
      return frequency; //Otherwise return the current frequency.
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

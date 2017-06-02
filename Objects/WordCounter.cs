using System;

namespace WordCounter
{
  public class WordCounter
  {
    //WordCounter class composed of word objects
    private string _word;

    public WordCounter(string word)
    {
      _word = word;
    }

    public string GetUserInput()
    {
      return _word;
    }



  }


}

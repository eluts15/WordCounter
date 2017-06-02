using Nancy;
using System;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };

      Post["/show_results"] = _ =>
      {
        WordRepeatCounter calculate = new WordRepeatCounter(Request.Form["users-input"], Request.Form["sick-word-bro"]);
          return View["show_results.cshtml", calculate];
      };
    }
  }
}

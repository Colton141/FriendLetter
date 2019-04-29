using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "sup dude"; }

    [Route("/goodbye")]
    public string Goodbye() { return "bye dude"; }

    [Route("/")]
    public ActionResult Letter()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Lina";
      myLetterVariable.Sender = "John";
      return View(myLetterVariable);
    }

    [Route("/journal")]
    public ActionResult Journal() { return View(); }

  }
}

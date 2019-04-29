using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "sup dude"; }

    [Route("/goodbye")]
    public string Goodbye() { return "bye dude"; }

    [Route("/")]
    public ActionResult Letter() { return View(); }

  }
}
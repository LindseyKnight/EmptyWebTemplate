using System.Web.Mvc;

namespace HelloWorld.Web.Controllers
{
    public sealed class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Home()
        {
            return View("Home");
        }
    }
}
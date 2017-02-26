using System.Web.Mvc;

namespace HelloWorld.Web.Controllers
{
    public sealed class ErrorController : Controller
    {
        public ActionResult Error()
        {
            return View("Error");
        }
    }
}
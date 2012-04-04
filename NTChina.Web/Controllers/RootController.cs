using System.Web.Mvc;

namespace NTChina.Web.Controllers
{
    public class RootController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Topic(int id)
        {
            return View();
        }

        public ActionResult Node(string id)
        {
            return View();
        }

        public ActionResult Member(string id)
        {
            return View();
        }

        public ActionResult LogOn()
        {
            return View();
        }

        public ActionResult LogOff()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}

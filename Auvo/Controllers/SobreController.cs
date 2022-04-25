using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auvo.Controllers
{
    public class SobreController : Controller
    {
        // GET: SobreController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SobreController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

    }
}

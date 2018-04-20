using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUi.Controllers
{
    public class HomeController : Controller
    {


        // GET: Home
        [Route("/")]
        public ActionResult Index()
        {
            return View();
        }
        [Route("/Hakkimizda")]
        public ActionResult Hakkimizda()
        {
            return View();
        }
        [Route("/Hizmetlerimiz")]
        public ActionResult Hizmetlerimiz()
        {
            return View();
        }
        [Route("/Iletisim")]
        public ActionResult Iletisim()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Brincanagem_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Aqui você vai encontrar as opiniões do autor do site sobre os filmes da DC.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Aqui você vai encontrar as opiniões do autor do site sobre os filmes da Marvel.";

            return View();
        }
    }
}
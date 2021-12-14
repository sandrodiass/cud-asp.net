using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GerenciadorDeConteudo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "testando";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "contarto da pagina .";

            return View();
        }
    }
}
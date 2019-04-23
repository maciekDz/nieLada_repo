using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NieLada.Controllers
{
    public class HomeController : Controller
    {
        //public string altFooter = "Powered by &copy; KT STUDIO " + @DateTime.Now.Year; 

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            

            return View();
        }

        public ActionResult Onas()
        {
            ViewBag.altFooter ="Powered by &copy; KT STUDIO " + @DateTime.Now.Year;
            ViewBag.text = "Przykładowy text o KT STUDIO";
            return View();
        }
    }
}
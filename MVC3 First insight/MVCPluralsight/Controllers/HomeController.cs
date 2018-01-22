using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPluralsight.Models;
namespace MVCPluralsight.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var model = new Hotels() {
                Name = "Nagarjuna",
                Rating = 6               
            };
            //ViewBag.Razor = "Hellow Razor, Good job";
            ViewBag.Razor = string.Concat(RouteData.Values["action"], RouteData.Values["controller"],RouteData.Values["id"]);
            return View( model);
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
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPluralsight.Controllers
{
    //[Infrastructure.ErrorFilterHandler]
    public class CousineController : Controller
    {
        // GET: Cousine
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Search(string city,string name="*" )
        {
            throw new Exception("Ooops! unknown error occured, Sorry.");
            name = Server.HtmlEncode(name);
            city = Server.HtmlEncode(city);
            if (name == "*")
            {
                return RedirectToAction("Search", "Cousine", new { name = "Dakshya", city = "Mumbai" });
            }
            else if (name == "$") {
                return File(Server.MapPath("~/Content/Site.css"), "text/css");
            }
            else if (name == "1")
            {
                return Json(new { Name = "Dakashya", FatherName = "Madhu", Mothername = "Sirisha" }, JsonRequestBehavior.AllowGet );
            }
            return Content( string.Format("Name : {0}, City : {1}",name,city));
            //return RedirectPermanent("https://microsoft.com/");
            //return RedirectToAction("Dakshya/Vishakpatnam");
        }



    }
}
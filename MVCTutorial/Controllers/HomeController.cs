using MVCTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // connection open
            using(MvcDemo db = new MvcDemo())
            {
                var user = db.Users.Select(i=>i.EmailAddress).Where(i => i.ToUpper() == "emai").FirstOrDefault();
                // var item = db.WorkItems.Where(x=>x.Id==5).Select(i=>i.Name=="diju").FirstOrDefault();
                // string email = user.EmailAddress;
                return View(user);
            }
            // connection close
            //,oreturn View(user);
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
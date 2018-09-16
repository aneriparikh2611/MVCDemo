using MVCTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class AddressController : Controller
    {
        // GET: Address
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreatAddress()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreatAddress(Address model)
        {
            using (MvcData db = new MvcData())
            {
                var add = new Address()
                {
                    Id = 0,
                    PostalCode = model.PostalCode,
                    Street = model.Street,
                    StreetNumber = model.StreetNumber
                };

                db.Addresses.Add(add);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
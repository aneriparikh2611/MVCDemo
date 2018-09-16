//using MVCTutorial.Models;
using MVCTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        // HttpGet
        public ActionResult Create()
        {
            return View();
        }

        //Httppost
        [HttpPost]
        public ActionResult Create(Customer model)
        {
            using (MvcData db= new MvcData())
            {
                var customer = new Customer()
                {
                    Id = 0,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    PhoneNumber = model.PhoneNumber
                };
                db.Customers.Add(customer);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
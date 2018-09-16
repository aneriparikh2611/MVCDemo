//using MVCTutorial.Models;
using MVCTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Creatuser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Creatuser(Student model)
        {
            using (Model1 db = new Model1())
            {
                var student = new MVCTutorial.Models.Student()
                {
                    Id=model.Id,
                    Name=model.Name,
                    Email=model.Email,
                    PhoneNumber=model.PhoneNumber
                };
                db.Students.Add(student);
                db.SaveChanges();
            }
            
                return RedirectToAction("Index");
        }
    }
}
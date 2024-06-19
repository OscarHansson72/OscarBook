using Facebook_2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using static DataLibrary.BusinessLogic.PersonProcessor;

namespace Facebook_2._0.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult SignUp()
        {
            ViewBag.Message = "Sign up page";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(SignUpModel model)
        {
            if(ModelState.IsValid)
            {
                int recordsCreated = CreatePerson(model.FirstName, 
                    model.LastName, 
                    model.Email, 
                    model.PhoneNumber, 
                    model.DateOfBirth, 
                    model.Password);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
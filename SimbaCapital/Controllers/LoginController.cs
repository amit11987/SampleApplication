using SimbaCapital.Model;
using SimbaCapital.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SimbaCapital.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        IPersonService PersonService;
        public LoginController(IPersonService PersonService)
        {
            this.PersonService = PersonService;

        }
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult LogOn()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ViewResult LogOn([Bind(Include = "Email,Password")] Person person)
        {

            if (string.IsNullOrEmpty(person.Email))
            {
                ModelState.AddModelError("", "Please Enter Email Id");
                return View(person);
            }
            if (string.IsNullOrEmpty(person.Password))
            {
                ModelState.AddModelError("", "Please Enter Password");
                return View(person);
            }
            
            if (PersonService.FindBy(p => p.Email.Trim() == person.Email.Trim() && p.Password == person.Password.Trim()).Count() > 0)
            {
                ViewBag.UserName = person.Name;
                FormsAuthentication.RedirectFromLoginPage(person.Email, false);
            }
            else
            {
                ModelState.AddModelError("", "EmailId or Password Incorrect.");
            }

            return View(person);
        }

    }
}


using SimbaCapital.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimbaCapital.Model;
namespace SimbaCapital.Controllers
{
    public class PersonController : Controller
    {
        //
        // GET: /Person/
        IPersonService PersonService;
        ICountryService CountryService;
        public PersonController(IPersonService PersonService, ICountryService CountryService)   
        {
            this.PersonService = PersonService;
            this.CountryService = CountryService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.CountryId = new SelectList(CountryService.GetAll(), "Id", "Name");
            return View();
        }

        // POST: /Person/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Company,Position,Address,Town,Postcode,CountryId,Phone,Fax,Email,PlaceOfIncorporation,PrincipalBusinessActivity,Regulator,RegulatorReference,Password,ConfirmPassword")] Person person)
        {
            if (ModelState.IsValid)
            {
                if (PersonService.FindBy(p => p.Email.Trim() == person.Email.Trim()).Count() > 0)
                {
                    ModelState.AddModelError("", "User Alreary Exists");
                }
                else
                {
                    PersonService.Create(person);
                    return RedirectToAction("Index");
                }
            }
            //ViewBag.CountryId = new SelectList(CountryService.GetAll(), "Id", "Name", person.CountryId);
            return View(person);
        }
    }
}

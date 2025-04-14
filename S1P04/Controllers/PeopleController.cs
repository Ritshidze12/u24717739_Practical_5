using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u24717739_Practical_5.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public static List<Models.PersonModel> people = new List<Models.PersonModel>();
        public ActionResult ListPeople()
        {


            people.Add(new Models.PersonModel
            {
                StuNumber = "u24717739",
                FirstName = "Ritshidze",
                LastName = "Nedzimauli",
                Email = "u24717739@tuks.co.za",
              
            });
            people.Add(new Models.PersonModel
            {
                StuNumber = "u24784606",
                FirstName = "Msizi",
                LastName = "Gumede",
               Email = "u24784606@tuks.co.za",

            });
            people.Add(new Models.PersonModel
            {
                StuNumber = "u24634400",
                FirstName = "Boitshoko",
                LastName = "Mphahlele",
                Email = "u24634400@tuks.co.za",             
            });
            people.Add(new Models.PersonModel
            {
               StuNumber = "u24724918",
               FirstName = "Gundo",
                LastName = "Ndou",
                Email = "u24724918@tuks.co.za",       
            });
            people.Add(new Models.PersonModel
            {
                StuNumber = "u24924142",
               FirstName = "Walter",
               LastName = "Marimi",
              Email = "u24924142@tuks.co.za",
            });

            return View(people);
        }

        
        [HttpGet]

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.PersonModel pm)
        {
            people.Add(new Models.PersonModel { FirstName = pm.FirstName, LastName = pm.LastName, Email = pm.Email,  StuNumber = pm.StuNumber });
            return RedirectToAction("ListPeople");

        }
    }
}
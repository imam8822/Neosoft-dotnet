using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class PetController : Controller
    {
        // GET: Pet
        public ActionResult Index()
        {
            return View(GetCats());
        }
        [NonAction]
        public IEnumerable<Cat> GetCats()
        {
            List<Cat> cats = new List<Cat>()
            {
                new Cat(){Id=1, Name="Kitty", Gender=Gender.Female},
                new Cat(){Id=2, Name="Billy", Gender=Gender.Female},
                new Cat(){Id=3, Name="Tome", Gender=Gender.Male},
                new Cat(){Id=4, Name="Meow", Gender=Gender.Male},
                new Cat(){Id=5, Name="Lofer", Gender=Gender.Male}
            };
            return cats;
        }
    }
}
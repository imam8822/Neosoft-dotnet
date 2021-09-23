using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVC.Controllers
{
    public class SuperHeroController : Controller
    {
        public IActionResult Index()
        {            
            return View(SuperHero.getDummySuperHeros());
        }
    }
}

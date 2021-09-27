using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Data;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CoreMVC.Controllers
{
    public class SuperHeroController : Controller
    {
        private readonly IRepository repo;
        public SuperHeroController(IRepository _repo)
        {
            repo = _repo;
        }
        public IActionResult Index()
        {
            return View(Mapper.Map(repo.GetSuperHeroes()));
        }
        public IActionResult Details(int id)
        {
            return View(Mapper.Map(repo.GetSuperHeroById(id)));
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(SuperHero superHero)
        {
            if (ModelState.IsValid) {
                repo.Add(Mapper.Map(superHero));
                return RedirectToAction("Index");
            }
            else
                return View(superHero);
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            if (id > 0)
            {
                var data = repo.GetSuperHeroById(id);
                if (data != null)
                {
                    return View(Mapper.Map(data));
                }
            }
            return RedirectToAction("Index");
        }
       [HttpPost]
        public IActionResult Update(SuperHero sup)
        {
            repo.Edit(Mapper.Map(sup));
            return RedirectToAction("Index");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;
using Data.Entities;
using Data;
using System.Net;
using Cat = Data.Entities.Cat;

namespace Web.Controllers
{
    public class PetController : Controller
    {
        CatRepository repo;
        public PetController()
        {
            repo = new CatRepository(new PetModel());
        }
        // GET: Pet
        public ActionResult Index()
        {
            var cats = repo.GetCats();
            var data = new List<Web.Models.Cat>();
            foreach (var c in cats)
            {
                data.Add(Mapper.Map(c));
            }
            return View(data);
        }
        // GET:PetById
        public ActionResult GetCatById(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var cat = repo.GetCatById(id);
            if (cat == null)
                return HttpNotFound();
            return View(Mapper.Map(cat));
        }
        // GET:Form
        [HttpGet]
        public ViewResult Create()
        {
            ViewBag.CatType = new SelectList(repo.getCatType(), "Id", "Name");
            ViewBag.FurType = new SelectList(repo.getFurType(), "Id", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Create(CatViewModel cat)
        {
            if (ModelState.IsValid)
            {
                repo.AddCat(Mapper.Map(cat));
                return RedirectToAction("Index");
            }
            return View(cat);
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var cat = repo.GetCatById(id);
            if (cat == null)
            {
                return HttpNotFound();
            }
            else
            {
                ViewBag.CatType = new SelectList(repo.getCatType(), "Id", "Name",cat.CatType);
                TempData["CatType"] = cat.CatType;
                ViewBag.FurType = new SelectList(repo.getFurType(), "Id", "Name", cat.FurType);
                TempData["FurType"] = cat.FurType;
                TempData["Dob"] = cat.Dob?.ToString("MM/dd/yyyy");
            }
            return View(Mapper.MapCVM(cat));
        }
        [HttpPost]
        public ActionResult Edit(CatViewModel cat)
        {
            if (ModelState.IsValid)
            {
                Cat update = new Cat();
                update.Id = cat.Id;
                update.Name = cat.Name;
                update.Dob = cat.Dob;
                update.legLength = cat.legLength;
                update.ribcage = cat.ribLength;
                update.GenderId = cat.GenderId;
                update.CatType = cat.CatType;
                update.FurType = cat.FurType;
                repo.UpdateCat(update);
                return RedirectToAction("Index");
            }
            return View(cat);
        }

    }
}
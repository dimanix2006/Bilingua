using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class LanguageController : Controller
    {
        DatabaseContext db = new DatabaseContext();

        // GET: Language
        public ActionResult Index()
        {
            var models = db.Languages;
            return View(models);
        }

        public ActionResult Details(int id)
        {
            Language model = db.Languages.Find(id);
            if (model == null) return View("NotFound");
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            Language model = new Language();
            UpdateModel(model, collection);
            db.Languages.Add(model);
            db.SaveChanges();
            return RedirectToAction("Details", new { id = model.ID });
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Language model = db.Languages.Find(id);
            if (model == null) return View("NotFound");
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            Language model = db.Languages.Find(id);
            if (model == null) return View("NotFound");
            UpdateModel(model, collection);
            db.SaveChanges();
            return RedirectToAction("Details", new { id = model.ID });
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Language model = db.Languages.Find(id);
            if (model == null) return View("NotFound");
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(int id,FormCollection collection)
        {
            Language model = db.Languages.Find(id);
            if (model == null) return View("NotFound");
            db.Languages.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
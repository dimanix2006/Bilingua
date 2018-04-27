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
        DBEntities db = new DBEntities();

        // Отображает список всех объектов
        public ActionResult Index()
        {
            var models = db.Languages;
            return View(models);
        }

        // Отображает карточку объекта, имеющего ID, задаваемый в параметре id
        public ActionResult Details(int id)
        {
            Language model = db.Languages.Find(id);
            if (model == null) return View("NotFound");
            return View(model);
        }

        // Открывает форму создания объекта
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // Обрабатывает данные, полученные из формы создания объекта
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            Language model = new Language();
            UpdateModel(model, collection);
            db.Languages.Add(model);
            db.SaveChanges();
            return RedirectToAction("Details", new { id = model.ID });
        }

        // Открывает форму редактирования
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Language model = db.Languages.Find(id);
            if (model == null) return View("NotFound");
            return View(model);
        }

        // Обрабатывает форму редактирования
        [HttpPost]
        public ActionResult Edit(int id,FormCollection collection)
        {
            Language model = db.Languages.Find(id);
            if (model == null) return View("NotFound");
            UpdateModel(model, collection);
            db.SaveChanges();
            return RedirectToAction("Details", new { id = model.ID });
        }

        // Открывает форму для удаления объекта
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Language model = db.Languages.Find(id);
            if (model == null) return View("NotFound");
            return View(model);
        }

        // Обрабатывает форму удаления объекта
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            Language model = db.Languages.Find(id);
            if (model == null) return View("NotFound");
            db.Languages.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
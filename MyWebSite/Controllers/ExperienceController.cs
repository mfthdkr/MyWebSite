using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSite.Controllers
{
    public class ExperienceController : Controller
    {
        private ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());
        public IActionResult Index()
        {
            ViewBag.vb1 = "Deneyim Listesi";
            ViewBag.vb2 = "Deneyimler";
            ViewBag.vb3 = "Deneyim Listesi ";
            var result = experienceManager.GetList();
            return View(result);
        }

        public IActionResult Create()
        {
            ViewBag.vb1 = "Deneyim Ekleme";
            ViewBag.vb2 = "Deneyimler";
            ViewBag.vb3 = "Deneyim Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult Create(Experience experience)
        {
            experienceManager.Add(experience);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var entity = experienceManager.GetById(id);
            experienceManager.Delete(entity);
            return RedirectToAction("Index");

        }
        public IActionResult Update(int id)
        {
            ViewBag.vb1 = "Deneyim Güncelleme";
            ViewBag.vb2 = "Deneyimler";
            ViewBag.vb3 = "Deneyim Güncelleme";
            var entity = experienceManager.GetById(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Update(Experience experience)
        {

            experienceManager.Update(experience);

            return RedirectToAction("Index");
        }

    }
}

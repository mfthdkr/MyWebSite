using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSite.Controllers
{
    public class SkillController : Controller
    {   
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            ViewBag.vb1 = "Yetenek Listesi";
            ViewBag.vb2 = "Yetenekler";
            ViewBag.vb3 = "Yetenek ";
            var result = skillManager.GetList();
            return View(result);
        }

        public IActionResult Create()
        {
            ViewBag.vb1 = "Yetenek Ekleme";
            ViewBag.vb2 = "Yetenekler";
            ViewBag.vb3 = "Yetenek Ekleme";
            return View();
        }
        [HttpPost]
        public IActionResult Create(Skill skill)
        {
            skillManager.Add(skill);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var entity = skillManager.GetById(id);
            skillManager.Delete(entity);
            return RedirectToAction("Index");

        }
        public  IActionResult Update(int id)
        {
            ViewBag.vb1 = "Yetenek Ekleme";
            ViewBag.vb2 = "Yetenekler";
            ViewBag.vb3 = "Yetenek Ekleme";
            var entity= skillManager.GetById(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Update(Skill skill)
        {
            

            skillManager.Update(skill);

            return RedirectToAction("Index");
        }
    }
}

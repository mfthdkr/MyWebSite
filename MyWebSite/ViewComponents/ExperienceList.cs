using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSite.ViewComponents
{
    public class ExperienceList: ViewComponent
    {
        private ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());

        public IViewComponentResult Invoke()
        {
            var result = experienceManager.GetList();
            return View(result);
        }
    }
}

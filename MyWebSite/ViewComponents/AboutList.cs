using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSite.ViewComponents
{
    public class AboutList: ViewComponent
    {
        AboutManager aboutManager= new AboutManager(new EfAboutDal());

        public IViewComponentResult Invoke()
        {
            var result = aboutManager.GetList();
            return View(result);
        }
    }
}

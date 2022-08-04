using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSite.ViewComponents
{
    public class TestiomonialList: ViewComponent
    {
        TestimonialManager testimonialManager= new TestimonialManager(new EfTestimonialDal());

        public IViewComponentResult Invoke()
        {
            var result=  testimonialManager.GetList();
            return View(result);
        }
    }
}

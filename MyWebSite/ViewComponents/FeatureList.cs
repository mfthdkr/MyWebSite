using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSite.ViewComponents
{
    public class FeatureList : ViewComponent
    {
        private FeatureManager featureManager = new FeatureManager(new EfFeatureDal());

        public IViewComponentResult Invoke()
        {
            var result = featureManager.GetList();
            return View(result);
        }
    }
}

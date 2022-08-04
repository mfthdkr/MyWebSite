using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSite.ViewComponents
{
    public class PortfolioList: ViewComponent
    {
        private PortfolioManager _portfolioManager = new PortfolioManager(new EfPortfolioDal());

        public IViewComponentResult Invoke()
        {
            var result = _portfolioManager.GetList();
            return View(result);
        }
    }
}

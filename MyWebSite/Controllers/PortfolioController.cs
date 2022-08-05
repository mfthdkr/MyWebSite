using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSite.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly PortfolioManager _portfolioManager = new PortfolioManager(new EfPortfolioDal());
        public IActionResult Index()
        {
            ViewBag.vb1 = "Proje Listesi";
            ViewBag.vb2 = "Projelerim";
            ViewBag.vb3 = "Projeler ";
            var result = _portfolioManager.GetList();

            return View(result);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Portfolio portfolio)
        {       
            PortfolioValidator portfolioValidator = new PortfolioValidator();
            ValidationResult validationResults = portfolioValidator.Validate(portfolio);
            if (validationResults.IsValid)
            {
                _portfolioManager.Add(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResults.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            var entity = _portfolioManager.GetById(id);
            _portfolioManager.Delete(entity);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var entity = _portfolioManager.GetById(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Update(Portfolio portfolio)
        {
            PortfolioValidator portfolioValidator = new PortfolioValidator();
            ValidationResult validationResult = portfolioValidator.Validate(portfolio);
            if (validationResult.IsValid)
            {
                _portfolioManager.Update(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }

            return View();

        }
    }
}

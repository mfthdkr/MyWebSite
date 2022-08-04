using System;
using System.Diagnostics.CodeAnalysis;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSite.Controllers
{
    public class DefaultController : Controller
    {
        private MessageManager messageManager = new MessageManager(new EfMessageDal());
        public IActionResult Index()
        {

            return View();
        }

        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            message.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            message.Status = true;
            messageManager.Add(message);
            return RedirectToAction("Index");
        }
    }
}

using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var values = _aboutService.GetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(About about)
        {
            _aboutService.Update(about);
            return RedirectToAction("Index", "Default");
        }
    }
}

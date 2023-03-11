using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
	public class TestimonialController : Controller
	{
		private readonly ITestimonialService _testimonialService;

		public TestimonialController(ITestimonialService testimonialService)
		{
			_testimonialService = testimonialService;
		}
		public IActionResult Index()
		{
			var values = _testimonialService.GetList();
			return View(values);
		}
		public IActionResult DeleteTestimonial(int id)
		{
			var values = _testimonialService.GetByID(id);
			_testimonialService.Delete(values);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult EditTestimonial(int id)
		{
			var values = _testimonialService.GetByID(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult EditTestimonial(Testimonial testimonial)
		{
			_testimonialService.Update(testimonial);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult AddTestimonial()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddTestimonial(Testimonial testimonial)
		{
			_testimonialService.Add(testimonial);
			return RedirectToAction("Index");
		}
	}
}

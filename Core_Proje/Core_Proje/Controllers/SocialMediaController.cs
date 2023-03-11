using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
	public class SocialMediaController : Controller
	{
		private readonly ISocialMediaService _socialMediaService;

		public SocialMediaController(ISocialMediaService socialMediaService)
		{
			_socialMediaService = socialMediaService;
		}
		public IActionResult Index()
		{
			var values = _socialMediaService.GetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddSocialMedia()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddSocialMedia(SocialMedia socialMedia)
		{
			_socialMediaService.Add(socialMedia);
			return RedirectToAction("Index");
		}
		public IActionResult DeleteSocialMedia(int id)
		{
			var values = _socialMediaService.GetByID(id);
			_socialMediaService.Delete(values);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult EditSocialMedia(int id)
		{
			SocialMedia socialMedia = _socialMediaService.GetByID(id);
			return View(socialMedia);
		}
		[HttpPost]
		public IActionResult EditSocialMedia(SocialMedia socialMedia)
		{
			_socialMediaService.Update(socialMedia);
			return RedirectToAction("Index");
		}
	}
}

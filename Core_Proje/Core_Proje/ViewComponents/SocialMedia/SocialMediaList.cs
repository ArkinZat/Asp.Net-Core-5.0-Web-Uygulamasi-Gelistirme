using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.SocialMedia
{ 
	public class SocialMediaList : ViewComponent
	{
		private readonly ISocialMediaService _socialMediaService;

		public SocialMediaList(ISocialMediaService socialMediaService)
		{
			_socialMediaService = socialMediaService;
		}
		public IViewComponentResult Invoke()
		{
			var values = _socialMediaService.GetList();
			return View(values);
		}
	}
}

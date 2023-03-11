using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{
	[Area("Writer")]
	[Authorize]
	public class DefaultController : Controller
	{
		private readonly IAnnouncementService _announcementService;

		public DefaultController(IAnnouncementService announcementService)
		{
			_announcementService = announcementService;
		}
		public IActionResult Index()
		{
			var values = _announcementService.GetList();
			return View(values);
		}

		public IActionResult AnnouncementDetails(int id)
		{
			Announcement announcement = _announcementService.GetByID(id);
			return View(announcement);
		}
	}
}

using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
	public class ContactSubplaceController : Controller
	{
		private readonly IContactService _contactService;

		public ContactSubplaceController(IContactService contactService)
		{
			_contactService = contactService;
		}
		[HttpGet]
		public IActionResult Index()
		{
			var values = _contactService.GetByID(1);
			return View(values);
		}
		[HttpPost]
		public IActionResult Index(Contact contact)
		{
			_contactService.Update(contact);
			return RedirectToAction("Index", "Default");
		}
	}
}

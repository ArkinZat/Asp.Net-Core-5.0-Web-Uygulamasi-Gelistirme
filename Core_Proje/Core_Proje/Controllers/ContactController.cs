using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
	public class ContactController : Controller
	{
		private readonly IMessageService _messageService;

		public ContactController(IMessageService messageService)
		{
			_messageService = messageService;
		}
		public IActionResult Index()
		{
			var values = _messageService.GetList();
			return View(values);
		}

		public IActionResult DeleteContact(int id)
		{
			var values = _messageService.GetByID(id);
			_messageService.Delete(values);
			return RedirectToAction("Index");
		}
		public IActionResult ContactDetails(int id)
		{
			var values = _messageService.GetByID(id);
			return View(values);
		}
	}
}

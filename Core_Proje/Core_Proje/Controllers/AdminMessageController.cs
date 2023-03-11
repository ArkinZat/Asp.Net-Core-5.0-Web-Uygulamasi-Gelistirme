using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
	public class AdminMessageController : Controller
	{
		private readonly IWriterMessageService _writerMessageService;

		public AdminMessageController(IWriterMessageService writerMessageService)
		{
			_writerMessageService = writerMessageService;
		}
		public IActionResult ReceiverMessageList()
		{
			string mail = "admin@gmail.com";
			var values = _writerMessageService.GetListReceiverMessage(mail);
			return View(values);
		}
		public IActionResult SenderMessageList()
		{
			string mail = "admin@gmail.com";
			var values = _writerMessageService.GetListSenderMessage(mail);
			return View(values);
		}
		public IActionResult AdminMessageDetails(int id)
		{
			var values = _writerMessageService.GetByID(id);
			return View(values);
		}
		public IActionResult AdminMessageDelete(int id)
		{
			string mail = "admin@gmail.com";
			var values = _writerMessageService.GetByID(id);
			if (values.Receiver == mail)
			{
				_writerMessageService.Delete(values);
				return RedirectToAction("ReceiverMessageList");
			}
			_writerMessageService.Delete(values);
			return RedirectToAction("SenderMessageList");
		}
		[HttpGet]
		public IActionResult AdminMessageSend()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AdminMessageSend(WriterMessage writerMessage)
		{
			writerMessage.Sender = "admin@gmail.com";
			writerMessage.SenderName = "Admin";
			writerMessage.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			Context c = new Context();
			var usernamesurname = c.Users.Where(x => x.Email == writerMessage.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
			writerMessage.ReceiverName = usernamesurname;
			_writerMessageService.Add(writerMessage);
			return RedirectToAction("SenderMessageList");
		}
	}
}

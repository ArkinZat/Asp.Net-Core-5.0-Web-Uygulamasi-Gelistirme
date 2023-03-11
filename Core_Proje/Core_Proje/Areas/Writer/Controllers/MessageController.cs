
using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{
	[Area("Writer")]
	[Route("Writer/[controller]")]
	public class MessageController : Controller
	{
		private readonly IWriterMessageService _writerMessageService;
		private readonly UserManager<WriterUser> _userManager;

		public MessageController(IWriterMessageService writerMessageService, UserManager<WriterUser> userManager)
		{
			_writerMessageService = writerMessageService;
			_userManager = userManager;
		}
		[Route("[action]")]
		public async Task<IActionResult> ReceiverMessage(string p)
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			p = values.Email;
			var messageList = _writerMessageService.GetListReceiverMessage(p);
			return View(messageList);
		}
		[Route("[action]")]
		public async Task<IActionResult> SenderMessage(string p)
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			p = values.Email;
			var messageList = _writerMessageService.GetListSenderMessage(p);
			return View(messageList);
		}
		[Route("[action]/{id}")]
		public IActionResult MessageDetails(int id)
		{
			WriterMessage writerMessage = _writerMessageService.GetByID(id);
			return View(writerMessage);
		}
		[Route("[action]/{id}")]
		public IActionResult ReceiverMessageDetails(int id)
		{
			WriterMessage writerMessage = _writerMessageService.GetByID(id);
			return View(writerMessage);
		}
		[HttpGet]
		[Route("[action]")]
		public IActionResult SendMessage()
		{
			return View();
		}
		[HttpPost]
		[Route("[action]")]
		public async Task<IActionResult> SendMessage(WriterMessage writerMessage)
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			writerMessage.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			writerMessage.Sender = values.Email;
			writerMessage.SenderName = values.Name + " " + values.Surname;
			Context c = new Context();
			var usernamesurname = c.Users.Where(x => x.Email == writerMessage.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
			writerMessage.ReceiverName = usernamesurname;
			_writerMessageService.Add(writerMessage);
			return RedirectToAction("SenderMessage");
		}
	}
}

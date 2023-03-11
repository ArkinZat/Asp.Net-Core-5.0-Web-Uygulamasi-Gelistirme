using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Dashboard
{
	public class AdminNavbarMessageList : ViewComponent
	{
		private readonly IWriterMessageService _writerMessageService;

		public AdminNavbarMessageList(IWriterMessageService writerMessageService)
		{
			_writerMessageService = writerMessageService;
		}
		public IViewComponentResult Invoke()
		{
			string mail = "admin@gmail.com";
			var values = _writerMessageService.GetListReceiverMessage(mail).OrderByDescending(x => x.WirterMessageID).Take(3).ToList();
			return View(values);
		}
	}
}

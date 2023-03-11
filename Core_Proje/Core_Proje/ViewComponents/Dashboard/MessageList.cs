using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Dashboard
{
	public class MessageList : ViewComponent
	{
		private readonly IMessageService _messageService;

		public MessageList(IMessageService messageService)
		{
			_messageService = messageService;
		}
		public IViewComponentResult Invoke()
		{
			var values = _messageService.GetList().Take(5).ToList();
			return View(values);
		}
	}
}

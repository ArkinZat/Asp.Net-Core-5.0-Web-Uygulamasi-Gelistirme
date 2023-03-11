using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Dashboard
{
	public class ToDoListPanel : ViewComponent
	{
		private readonly IToDoListService _toDoListService;

		public ToDoListPanel(IToDoListService toDoListService)
		{
			_toDoListService = toDoListService;
		}
		
		public IViewComponentResult Invoke()
		{
			var values = _toDoListService.GetList();
			return View(values);
		}
	}
}

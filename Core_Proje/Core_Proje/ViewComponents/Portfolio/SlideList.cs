using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Portfolio
{
	public class SlideList : ViewComponent
	{
		private readonly IPortfolioService _portfolioService;

		public SlideList(IPortfolioService portfolioService)
		{
			_portfolioService = portfolioService;
		}
		public IViewComponentResult Invoke()
		{
			var values = _portfolioService.GetList();
			return View(values);
		}
	}
}

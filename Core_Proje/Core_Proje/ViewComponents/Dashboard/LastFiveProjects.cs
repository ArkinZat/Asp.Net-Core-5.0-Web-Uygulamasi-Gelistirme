using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class LastFiveProjects : ViewComponent
    {
		private readonly IPortfolioService _portfolioService;

		public LastFiveProjects(IPortfolioService portfolioService)
		{
			_portfolioService = portfolioService;
		}
        public IViewComponentResult Invoke()
        {
            var values = _portfolioService.GetList().OrderBy(x => x.PortfolioID).Take(5).ToList();
            return View(values);
        }
    }
}

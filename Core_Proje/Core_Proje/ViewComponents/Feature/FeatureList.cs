using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {
        private readonly IFeatureService _featureService;

        public FeatureList(IFeatureService featureService)
        {
            _featureService = featureService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _featureService.GetList();
            return View(values);
        }
    }
}

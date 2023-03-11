using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
	public class ExperienceAjaxController : Controller
	{
		private readonly IExperienceService _experienceService;

		public ExperienceAjaxController(IExperienceService experienceService)
		{
			_experienceService = experienceService;
		}
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult ListExperience()
		{
			var values = JsonConvert.SerializeObject(_experienceService.GetList());
			return Json(values);
		}
		[HttpPost]
		public IActionResult AddExperience(Experience experience)
		{
			_experienceService.Add(experience);
			var values = JsonConvert.SerializeObject(experience);
			return Json(values);
		}
		public IActionResult GetById(int id)
		{
			Experience experience = _experienceService.GetByID(id);
			var values = JsonConvert.SerializeObject(experience);
			return Json(values);
		}
		public IActionResult DeleteExperience(int id)
		{
			Experience experience = _experienceService.GetByID(id);
			_experienceService.Delete(experience);
			return NoContent();
		}
		public IActionResult UpdateExperience(Experience experience)
		{
			Experience updateExperience = _experienceService.GetByID(experience.ExperienceID);
			updateExperience.Name = experience.Name;
			updateExperience.Date = experience.Date;
			_experienceService.Update(updateExperience);
			var values = JsonConvert.SerializeObject(updateExperience);
			return Json(values);
		}
	}
}

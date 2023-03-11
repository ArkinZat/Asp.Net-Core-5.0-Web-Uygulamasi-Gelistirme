using Core_Proje.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{
	[AllowAnonymous]
	[Area("Writer")]
	[Route("Writer/[controller]/[action]")]
	public class RegisterController : Controller
	{
		private readonly UserManager<WriterUser> _userManager;

		public RegisterController(UserManager<WriterUser> userManager)
		{
			_userManager = userManager;
		}
		[HttpGet]
		public IActionResult Index()
		{
			return View(new UserRegisterViewModel());
		}
		[HttpPost]
		public async Task<IActionResult> Index(UserRegisterViewModel userRegisterVM)
		{
			if (!ModelState.IsValid)
			{
				return View(userRegisterVM);
			}

			WriterUser writerUser = new WriterUser()
			{
				Name = userRegisterVM.Name,
				Surname = userRegisterVM.Surname,
				Email = userRegisterVM.Mail,
				UserName = userRegisterVM.UserName,
				ImageUrl = userRegisterVM.ImageUrl
			};

			var result = await _userManager.CreateAsync(writerUser, userRegisterVM.Password);

			if (result.Succeeded)
			{
				return RedirectToAction("Index", "Login");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError("", item.Description);
				}
				return View(userRegisterVM);
			}
			
		}
	}
}

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
	public class LoginController : Controller
	{
		private readonly SignInManager<WriterUser> _signInManager;

		public LoginController(SignInManager<WriterUser> signInManager)
		{
			_signInManager = signInManager;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(UserLoginViewModel userLoginViewModel)
		{
			if (!ModelState.IsValid)
			{
				return View();
			}

			var result = await _signInManager.PasswordSignInAsync(userLoginViewModel.Username, userLoginViewModel.Password, true, true);
			if (result.Succeeded)
			{
				return RedirectToAction("Update", "Profile");
			}
			else
			{
				ModelState.AddModelError("", "Hatalı kullanıcı adı veya şifre");
				return View();
			}
		}

		public async Task<IActionResult> LogOut()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction("Index");
		}
	}
}

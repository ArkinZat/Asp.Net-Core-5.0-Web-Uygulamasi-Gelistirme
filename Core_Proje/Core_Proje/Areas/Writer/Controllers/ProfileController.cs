using Core_Proje.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{
	[Area("Writer")]
	[Route("Writer/[controller]/[action]")]
	public class ProfileController : Controller
	{
		private readonly UserManager<WriterUser> _userManager;

		public ProfileController(UserManager<WriterUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpGet]
		public async Task<IActionResult> Update()
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			UserEditViewModel userEditViewModel = new UserEditViewModel();
			userEditViewModel.Name = values.Name;
			userEditViewModel.Surname = values.Surname;
			userEditViewModel.PictureURL = values.ImageUrl;
			return View(userEditViewModel);
		}

		[HttpPost]
		public async Task<IActionResult> Update(UserEditViewModel userEditViewModel)
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);
			if (userEditViewModel.Picture != null)
			{
				var resource = Directory.GetCurrentDirectory();
				var extension = Path.GetExtension(userEditViewModel.Picture.FileName);
				var imagename = Guid.NewGuid() + extension;
				var savelocation = resource + "/wwwroot/userimage/" + imagename;
				var stream = new FileStream(savelocation, FileMode.Create);
				await userEditViewModel.Picture.CopyToAsync(stream);
				user.ImageUrl = imagename;
			}
			user.Name = userEditViewModel.Name;
			user.Surname = userEditViewModel.Surname;
			user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditViewModel.Password);
			var result = await _userManager.UpdateAsync(user);
			if (!result.Succeeded)
			{
				return View();
			}
			return RedirectToAction("Index", "Default");
		}
	}
}

using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Models
{
	public class UserEditViewModel
	{
		[Required(ErrorMessage = "Lütfen Adınızı Girin.")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Lütfen Soyadını Girin.")]
		public string Surname { get; set; }
		[Required(ErrorMessage = "Lütfen Şifreyi Girin.")]
		public string Password { get; set; }
		[Required(ErrorMessage = "Lütfen Şifreyi Tekrar Girin.")]
		[Compare("Password", ErrorMessage = "Şifreler Uyumlu Değil !")]
		public string PasswordConfirm { get; set; }
		public string PictureURL { get; set; }
		public IFormFile Picture { get; set; }
	}
}

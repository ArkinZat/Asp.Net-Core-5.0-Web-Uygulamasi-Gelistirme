using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Contact
{
    public class ContactDetails : ViewComponent
    {
		private readonly IContactService _contactService;

		public ContactDetails(IContactService contactService)
		{
			_contactService = contactService;
		}
        public IViewComponentResult Invoke()
        {
            var values = _contactService.GetList();
            return View(values);
        }
    }
}

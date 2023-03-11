using Core_Proje_Api.DAL.ApiContext;
using Core_Proje_Api.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje_Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		[HttpGet]
		[Route("[action]")]
		 public IActionResult CategoryList()
		{
			using var c = new Context();
			return Ok(c.Categories.ToList());
		}

		[HttpGet]
		[Route("[action]")]
		public IActionResult GetCategory(int id)
		{
			using var c = new Context();
			var value = c.Categories.Find(id);
			if (value == null)
			{
				return NotFound();
			}
			else
			{
				return Ok(value);
			}
		}

		[HttpPost]
		[Route("[action]")]
		public IActionResult AddCategory(Category category)
		{
			using var c = new Context();
			c.Add(category);
			c.SaveChanges();
			return Created("", category);
		}

		[HttpDelete]
		[Route("[action]")]
		public IActionResult DeleteCategory(int id)
		{
			using var c = new Context();
			var value = c.Categories.Find(id);
			if(value == null)
			{
				return NotFound();
			}
			else
			{
				c.Categories.Remove(value);
				c.SaveChanges();
				return NoContent();
			}
		}

		[HttpPut]
		[Route("[action]")]
		public IActionResult EditCategory(Category category)
		{
			using var c = new Context();
			var value = c.Find<Category>(category.CategoryID);
			if (value == null)
			{
				return NotFound();
			}
			else
			{
				value.CategoryName = category.CategoryName;
				c.Update(value);
				c.SaveChanges();
				return Ok(category);
			}
		}

	}
}

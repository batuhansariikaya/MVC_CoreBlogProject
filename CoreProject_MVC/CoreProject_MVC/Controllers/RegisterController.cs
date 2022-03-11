using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject_MVC.Controllers
{
	[AllowAnonymous]
	public class RegisterController : Controller
	{
		
		WriterManager writerManager = new WriterManager(new EfWriterRepository());
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(Writer writer)
		{
			WriterValidator validationRules = new WriterValidator();
			ValidationResult result = validationRules.Validate(writer);
			if (result.IsValid)
			{
				writer.WriterStatus = true;
				
				writerManager.TAdd(writer);
				return RedirectToAction("Index", "Login");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
				
			}
			return View();




		}
	}
}

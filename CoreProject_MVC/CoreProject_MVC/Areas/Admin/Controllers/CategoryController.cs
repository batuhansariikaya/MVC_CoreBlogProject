using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;
namespace CoreProject_MVC.Areas.Admin.Controllers
{
	[Area("Admin")]
	[AllowAnonymous]
	public class CategoryController : Controller
	{
		
		CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
		public IActionResult Index(int page=1)
		{
			var categoryList = categoryManager.GetList().ToPagedList(page,5);
			return View(categoryList);
		}
		[HttpGet]
		public IActionResult AddCategory()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddCategory(Category category)
		{
			CategoryValidator validations = new CategoryValidator();
			ValidationResult result = validations.Validate(category);
			if (result.IsValid)
			{
				category.CategoryStatus = true;
				categoryManager.TAdd(category);
				return RedirectToAction("Index");
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
		public IActionResult DeleteCategory(int id)
		{
			var delete = categoryManager.GetByID(id);
			categoryManager.TDelete(delete);
			return RedirectToAction("Index");
		}
	}
}

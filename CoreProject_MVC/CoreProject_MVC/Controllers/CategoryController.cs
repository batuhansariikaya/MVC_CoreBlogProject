using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject_MVC.Controllers
{
	public class CategoryController : Controller
	{
		CategoryManager cm = new CategoryManager(new EfCategoryRepository());
		public IActionResult Index()
		{
			var getCategory = cm.GetList();
			return View(getCategory);
		}
		
	}
}

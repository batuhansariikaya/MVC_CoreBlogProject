using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject_MVC.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class WidgetController : Controller
	{
		BlogManager blogManager = new BlogManager(new EfBlogRepository());
		CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
		public IActionResult Index()
		{
			ViewBag.blogCount = blogManager.GetList().Count;

			//var maxBlog = categoryManager.GetList();
			return View();
		}
	}
}

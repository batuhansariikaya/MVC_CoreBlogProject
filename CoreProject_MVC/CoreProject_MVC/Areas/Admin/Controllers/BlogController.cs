using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject_MVC.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class BlogController : Controller
	{

		BlogManager blogManager = new BlogManager(new EfBlogRepository());
		public IActionResult Index()
		{
			var blogList = blogManager.GetList();
			return View(blogList);
		}
		public IActionResult DeleteBlog(int id)
		{
			var delete = blogManager.GetByID(id);
			blogManager.TDelete(delete);
			return RedirectToAction("Index", "Blog", "Areas");
		}
		[HttpGet]
		public IActionResult GetBlogInfo(int id)
		{
			var blogInfo = blogManager.GetByID(id);
			return View(blogInfo);
		}
		[HttpPost]
		public IActionResult GetBlogInfo(Blog blog)
		{
			blogManager.TUpdate(blog);
			return RedirectToAction("Index", "Blog", "Areas");
		}
	}
}

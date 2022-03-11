using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject_MVC.ViewComponents.Blog
{
	public class BlogListDashboard:ViewComponent
	{
		BlogManager blogManager = new BlogManager(new EfBlogRepository());

		public IViewComponentResult Invoke()
		{
			var values = blogManager.GetListBlogWithCategoryName();
			return View(values);
		}
	}
}

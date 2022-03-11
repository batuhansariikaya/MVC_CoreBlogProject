using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject_MVC.ViewComponents.Category
{
	public class CategoryList:ViewComponent
	{
		CategoryManager cm = new CategoryManager(new EfCategoryRepository());
		public IViewComponentResult Invoke(int id)
		{
			var categoryList = cm.GetList();
			ViewBag.count = cm.GetCategoryListCount(id).Count;
			return View(categoryList);
		}
	}
}

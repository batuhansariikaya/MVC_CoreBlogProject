using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject_MVC.ViewComponents.Category
{
	public class CategoryListDashboard:ViewComponent
	{
		CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
		public IViewComponentResult Invoke()
		{
		
			
				var categoryList = categoryManager.GetList();
				return View(categoryList);
			
		}
	}
}

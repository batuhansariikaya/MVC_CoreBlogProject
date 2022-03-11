using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreProject_MVC.Controllers
{
	public class DashboardController : Controller
	{
		BlogManager blogManager = new BlogManager(new EfBlogRepository());

		public IActionResult Index()
		{
			var userMail = User.Identity.Name;
			Context context = new Context();
			var writerID = context.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
			ViewBag.blogCountbyWriter = blogManager.GetBlogListWithWriter(writerID).Count;
			ViewBag.blogCount = blogManager.GetList().Count;
			
			return View();
		}
	}
}

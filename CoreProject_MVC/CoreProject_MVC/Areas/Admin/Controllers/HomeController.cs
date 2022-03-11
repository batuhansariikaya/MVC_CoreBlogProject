using Microsoft.AspNetCore.Mvc;

namespace CoreProject_MVC.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

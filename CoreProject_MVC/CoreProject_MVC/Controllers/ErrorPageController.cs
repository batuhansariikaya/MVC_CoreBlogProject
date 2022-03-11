using Microsoft.AspNetCore.Mvc;

namespace CoreProject_MVC.Controllers
{
	public class ErrorPageController : Controller
	{
		public IActionResult Error404(int code)
		{
			ViewBag.errorcode = code;
			return View();
		}
	}
}

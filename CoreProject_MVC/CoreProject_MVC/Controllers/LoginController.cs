using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreProject_MVC.Controllers
{
	public class LoginController : Controller
	{
		[AllowAnonymous]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		[AllowAnonymous]
		public async Task<IActionResult> Index(Writer writer)
		{
			Context c = new Context();
			var datavalue = c.Writers.FirstOrDefault(x => x.WriterMail == writer.WriterMail &&
			  x.WriterPassword == writer.WriterPassword);
			if (datavalue.WriterStatus == true)
			{
				if (datavalue != null)
				{
					var claims = new List<Claim>
				{
					new Claim(ClaimTypes.Name,writer.WriterMail)
				};
					var userIdentity = new ClaimsIdentity(claims, "a");
					ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
					await HttpContext.SignInAsync(principal);
					return RedirectToAction("WriterBlogs", "Writer", new { area = "Writer" });
				}
			}	
			else
			{
				ViewBag.mesaj = "Bu yazar sistemden silinmiştir!!";
			}
			return View();
			



		}
		public async Task<IActionResult> LogOut()
		{
			await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
			return RedirectToAction("Index", "Blog");
		}
	}
}

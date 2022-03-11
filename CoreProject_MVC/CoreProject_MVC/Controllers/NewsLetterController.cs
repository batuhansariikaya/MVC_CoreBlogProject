using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject_MVC.Controllers
{
	[AllowAnonymous]
	public class NewsLetterController : Controller
	{
		NewsLetterManager lm = new NewsLetterManager(new EfNewsLetterRepository());
		[HttpGet]
		public PartialViewResult SubscribeMail()
		{
			return PartialView();
		}
		
		[HttpPost]
		public IActionResult SubscribeMail(NewsLetter letter)
		{
			letter.MailStatus = true;
			lm.TAdd(letter);
			return PartialView();
		}
	}
}

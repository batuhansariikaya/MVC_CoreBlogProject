using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreProject_MVC.Controllers
{
    public class WriterController : Controller
    {
		WriterManager wm = new WriterManager(new EfWriterRepository());
		[HttpGet]
		
		public IActionResult WriterProfileEdit(int id)
		{
			var userMail = User.Identity.Name;
			Context context = new Context();
			var writerID = context.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
			var profileInfo = wm.GetByID(writerID);
			return View(profileInfo);
		}
		[HttpPost]
	
		public IActionResult WriterProfileEdit(Writer writer)
		{
			//WriterValidator wl = new WriterValidator();
			//ValidationResult result = wl.Validate(writer);
			//if (result.IsValid)
			//{
				wm.TUpdate(writer);
				return RedirectToAction("Index", "Dashboard");
			//}
			//else
			//{
			//	foreach (var item in result.Errors)
			//	{
			//		ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
			//	}
			//}
			//return View();
		}
	}
}

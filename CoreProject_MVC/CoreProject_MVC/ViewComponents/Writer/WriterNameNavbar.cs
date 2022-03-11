using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreProject_MVC.ViewComponents.Writer
{
	public class WriterNameNavbar:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var userMail = User.Identity.Name;
			ViewBag.mail = userMail;
			Context context = new Context();
			var writerName = context.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterName + y.WriterSurname).FirstOrDefault();
			ViewBag.writerName = writerName;
			return View();
		}
	}
}

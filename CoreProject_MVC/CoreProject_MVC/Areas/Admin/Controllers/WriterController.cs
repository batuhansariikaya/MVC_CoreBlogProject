using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using EntityLayer.Concrete;
using DataAccessLayer.Concrete;
using X.PagedList.Mvc.Core;
using X.PagedList;

namespace CoreProject_MVC.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class WriterController : Controller
	{
		WriterManager writerManager = new WriterManager(new EfWriterRepository());
		Context context = new Context();
		public IActionResult Index(int page=1)
		{
			var writerInfo = writerManager.GetList().ToPagedList(page,6);
			return View(writerInfo);
		}
		public IActionResult AdminWriterProfilDetail(int id)
		{
			ViewBag.idd = id;
			var profileInfo = writerManager.GetListWriterInfo(id);
			return View(profileInfo);
		}
		[HttpGet]
		public IActionResult WriterAdd()
		{
			return View();
		}
		//public IActionResult WriterAdd(Writer )
		//{
		//	return View();
		//}
	}
}

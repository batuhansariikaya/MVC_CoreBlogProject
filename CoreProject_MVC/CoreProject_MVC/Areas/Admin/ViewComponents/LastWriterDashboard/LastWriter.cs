using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject_MVC.Areas.Admin.ViewComponents.LastWriterDashboard
{
	public class LastWriter:ViewComponent
	{
		WriterManager writerManager = new WriterManager(new EfWriterRepository());
		public IViewComponentResult Invoke()
		{
			var lastwriter = writerManager.GetListLastWriter();
			return View(lastwriter);
		}
	}
}

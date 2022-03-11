using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MVC_CoreProject.Areas.Writer.Controllers
{
	[Area("Writer")]
	public class MessageController : Controller
	{
		//MessageManager messageManager = new MessageManager(new EfMessageRepository());
		Context context = new Context();
		public IActionResult Index()
		{
			//var userMail = User.Identity.Name;
			//var writerID = context.Messages.Where(x => x.Writer.WriterName== userMail).Select(y => y.Sender).FirstOrDefault();
			//var myMessage = messageManager.GetListMessageByWriter(writerID);
			//return View(myMessage);
			return View();
		}
	}
}

using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject_MVC.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
       MessageManager messageManager = new MessageManager(new EfMessageRepository());
        public IViewComponentResult Invoke()
		{
            var WriterMessageList = messageManager.GetList();
            return View(WriterMessageList);
      
        }
    }
}

using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject_MVC.ViewComponents.Writer
{
    public class WriterNotification:ViewComponent
    {
        NotificationManager notification = new NotificationManager(new EfNotificationRepository());
        public IViewComponentResult Invoke()
        {
            var notificationList = notification.GetList();
            return View(notificationList);
        }
    }
}

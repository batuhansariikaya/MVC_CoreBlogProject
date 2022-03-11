using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace CoreProject_MVC.Areas.Admin.ViewComponents.Statistics
{
	public class WeatherAPI:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			string apiKey = "9e385de4c4e4f248bf33eae9653aec30";
		
			string connection = "https://api.openweathermap.org/data/2.5/weather?q=Ankara&mode=xml&lang=tr&units=metric&appid="+apiKey;
			XDocument document = XDocument.Load(connection);
			ViewBag.weather = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
			return View();
		}
	}
}

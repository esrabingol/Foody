using Microsoft.AspNetCore.Mvc;

namespace Foody.WEBUI.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

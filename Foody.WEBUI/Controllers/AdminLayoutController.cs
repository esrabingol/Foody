using Microsoft.AspNetCore.Mvc;

namespace Foody.WEBUI.Controllers
{
	public class AdminLayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

using Microsoft.AspNetCore.Mvc;

namespace Foody.WEBUI.Controllers
{
	public class ErrorPagesController : Controller
	{
		public IActionResult ErrorPage404()
		{
			return View();
		}
	}
}

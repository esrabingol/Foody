using Microsoft.AspNetCore.Mvc;

namespace Foody.WEBUI.ViewComponents.AdminLayoutViewComponents
{
	public class _FooterLayoutComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()

		{
			return View();
		}

	}
}

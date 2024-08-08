using Microsoft.AspNetCore.Mvc;

namespace Foody.WEBUI.ViewComponents.AdminLayoutViewComponents
{
	public class _MainPanelLayoutComponentPartial: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

using Microsoft.AspNetCore.Mvc;

namespace Foody.WEBUI.ViewComponents.AdminLayoutViewComponents
{
	public class _SidebarLayoutComponentPartial: ViewComponent
	{
		public IViewComponentResult Invoke()
		{ 
			return View(); 
		}


	}
}

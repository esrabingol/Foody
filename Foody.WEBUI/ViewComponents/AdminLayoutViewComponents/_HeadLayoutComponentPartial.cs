﻿using Microsoft.AspNetCore.Mvc;

namespace Foody.WEBUI.ViewComponents.AdminLayoutViewComponents
{
	public class _HeadLayoutComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

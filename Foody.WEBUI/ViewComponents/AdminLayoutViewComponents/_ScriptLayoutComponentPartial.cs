﻿using Microsoft.AspNetCore.Mvc;

namespace Foody.WEBUI.ViewComponents.AdminLayoutViewComponents
{
	public class _ScriptLayoutComponentPartial :ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

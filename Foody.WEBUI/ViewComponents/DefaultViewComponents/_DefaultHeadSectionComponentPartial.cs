using Microsoft.AspNetCore.Mvc;

namespace Foody.WEBUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultHeadSectionComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

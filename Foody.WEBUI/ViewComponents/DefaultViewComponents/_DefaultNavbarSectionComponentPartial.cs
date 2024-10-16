using Microsoft.AspNetCore.Mvc;

namespace Foody.WEBUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultNavbarSectionComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

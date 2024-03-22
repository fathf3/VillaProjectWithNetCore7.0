using Microsoft.AspNetCore.Mvc;

namespace Villa.WebUI.ViewComponents.UILayout
{
    public class _UISubHeader : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View();
        }
    }
}

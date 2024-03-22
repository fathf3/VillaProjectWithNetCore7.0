using Microsoft.AspNetCore.Mvc;

namespace Villa.WebUI.ViewComponents.UILayout
{
    public class _UIHeader : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

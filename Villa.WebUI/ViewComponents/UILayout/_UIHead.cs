﻿using Microsoft.AspNetCore.Mvc;

namespace Villa.WebUI.ViewComponents.UILayout
{
    public class _UIHead : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

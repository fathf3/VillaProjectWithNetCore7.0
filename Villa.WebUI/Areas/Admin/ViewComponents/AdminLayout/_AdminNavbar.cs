﻿using Microsoft.AspNetCore.Mvc;

namespace Villa.WebUI.Areas.Admin.ViewComponents.AdminLayout
{
    public class _AdminNavbar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

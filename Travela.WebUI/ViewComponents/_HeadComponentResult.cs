﻿using Microsoft.AspNetCore.Mvc;

namespace Travela.WebUI.ViewComponents
{
    public class _HeadComponentResult:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

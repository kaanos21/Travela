using Microsoft.AspNetCore.Mvc;

namespace Travela.WebUI.ViewComponents
{
    public class _NavbarComponentResult:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

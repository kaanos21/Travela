using Microsoft.AspNetCore.Mvc;

namespace Travela.WebUI.ViewComponents
{
    public class _ScriptComponentResult:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

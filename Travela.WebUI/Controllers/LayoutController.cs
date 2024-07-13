using Microsoft.AspNetCore.Mvc;

namespace Travela.WebUI.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

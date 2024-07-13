using Microsoft.AspNetCore.Mvc;

namespace Travela.WebUI.Controllers
{
    public class StatisricController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StatisricController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7065/api/Category/CategoryCount\r\n");
            var jstondata=await responseMessage.Content.ReadAsStringAsync();
            ViewBag.c=jstondata;
            return View();
        }
    }
}

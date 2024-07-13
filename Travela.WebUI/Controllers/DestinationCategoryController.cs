using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using Travela.WebUI.Dtos;

namespace Travela.WebUI.Controllers
{
    public class DestinationCategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DestinationCategoryController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public async  Task<IActionResult> Index(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7065/api/Destination/GetDestinationByCategory?id="+id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultDestinationByCategoryDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travela.BusinessLayer.Abstract;
using Travela.EntityLayer.Concrete;

namespace Travela.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinationController : ControllerBase
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        [HttpGet]
        public IActionResult DestinationList()
        {
            var value = _destinationService.TGetListAll();
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreatedDestination(Destination destination)
        {
            
            _destinationService.TInsert(destination);
            return Ok("Rota Başarıyla Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteDestination(int id)
        {
            _destinationService.TDelete(id);
            return Ok("Rota Başarıyla Silindi");
        }
        [HttpPut]
        public IActionResult UpdateDestination(Destination destination)
        {
            _destinationService.TUpdate(destination);
            return Ok("Güncelleme yapıldı");
        }
        [HttpGet("GetDestination")]
        public IActionResult GetDestination(int id)
        {
            return Ok(_destinationService.TGetById(id));
        }
        [HttpGet("GetDestinationByCategory")]
        public IActionResult GetDestinationByCategory(int id)
        {
            return Ok(_destinationService.TGetDestinationByCategoryList(id));
        }
        [HttpGet("GetDestinationByCategoryListAll")]
        public IActionResult GetDestinationByCategoryListAll()
        {
            var value = _destinationService.TGetDestinationByCategoryListAll();
            return Ok(value);
        }
    }
}

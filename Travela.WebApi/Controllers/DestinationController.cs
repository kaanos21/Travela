using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travela.BusinessLayer.Abstract;
using Travela.EntityLayer.Concrete;
using Travela.DataAccesLayer.Context;
using Microsoft.EntityFrameworkCore;
using Travela.WebApi.Models;

namespace Travela.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinationController : ControllerBase
    {
        private readonly IDestinationService _destinationService;
        private readonly TravelaContext _context;

        public DestinationController(IDestinationService destinationService, TravelaContext context)
        {
            _destinationService = destinationService;
            _context = context;
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

        [HttpGet("GetDestinationWithCategory")]
        public IActionResult GetDestinationWithCategory()
        {
            var values = _context.Destinations.Include(x => x.Category).Select(y => new GetDestinationWithCategoryModel
            {
                DestinationId = y.DestinationId,
                CategoryName = y.Category.CategoryName,
                City = y.City,
                CountDay = y.CountDay,
                Country = y.Country,
                ImageUrl = y.ImageUrl,
                SubTitle = y.SubTitle,
                Description = y.Description,
                Price = y.Price,
                Date = y.Date,
            }).ToList();
            return Ok(values);
        }
    }
}

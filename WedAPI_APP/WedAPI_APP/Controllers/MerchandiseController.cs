using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WedAPI_APP.Models;

namespace WedAPI_APP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MerchandiseController : ControllerBase
    {
        public static List<Merchandise> merchandises = new List<Merchandise>();

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(merchandises);
        }

        [HttpPost]
        public IActionResult CreateMerchandise(Merchandise merchandise)
        {

            var newMerchandise = new Merchandise
            {
                MerchandiseCode = Guid.NewGuid(),
                MerchandiseName = merchandise.MerchandiseName,
                Prices = merchandise.Prices
            };
            merchandises.Add(newMerchandise);
            return Ok(new {Success = true, Data= merchandises });
        }
    }
}

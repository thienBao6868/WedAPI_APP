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
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WedAPI_APP.Data;
using WedAPI_APP.Models;

namespace WedAPI_APP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MerchandiseController : ControllerBase
    {
        private readonly DataContext _context;

        public MerchandiseController(DataContext context)
        {
            _context = context;
        }

      

        [HttpGet]
        public  IActionResult GetAll()
        {
            var merchandiese = _context.Merchandises.ToList();
            return Ok(merchandiese);
        }

        [HttpPost]
        public IActionResult CreateMerchandise(Data.Merchandise model)
        {

            _context.Add(model);
            _context.SaveChanges();
            
            return Ok(new { Success = true, Data = "Create Success" });
        }
    }
}

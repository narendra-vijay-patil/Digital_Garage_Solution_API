using Digital_Garage_Solutions_API.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Digital_Garage_Solutions_API.DBCONTEXT;

namespace Digital_Garage_Solutions_API.Controllers
{
    [ApiController]
    [Route("api/carservice")]
    public class CarServiceController : ControllerBase
    {
        private readonly DataBase _context;

        public CarServiceController(DataBase context)
        {
            _context = context;
        }

        [HttpPost("bookservice")]
        public IActionResult BookCarService([FromBody] CarServiceBooking booking)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid booking data");

            _context.CarServiceBookings.Add(booking);
            _context.SaveChanges();

            return Ok("Car service booking successful!");
        }
    }
}


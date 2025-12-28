using Digital_Garage_Solutions_API.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Digital_Garage_Solutions_API.DBCONTEXT;

namespace Digital_Garage_Solutions_API.Controllers
{
    [ApiController]
    [Route("api/homemechanic")]
    public class HomeMechanicController : ControllerBase
    {
        private readonly DataBase _context;

        public HomeMechanicController(DataBase context)
        {
            _context = context;
        }

        [HttpPost("bookmechanic")]
        public IActionResult BookHomeMechanic([FromBody] HomeMechanicBooking booking)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid booking data");

            // Optional: Auto-allocate mechanic here
            booking.AllocatedMechanic = "Mechanic A";

            _context.HomeMechanicBookings.Add(booking);
            _context.SaveChanges();

            return Ok($"Mechanic allocated to {booking.Name} at {booking.Address}");
        }
    }
}


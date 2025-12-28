using Digital_Garage_Solutions_API.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Digital_Garage_Solutions_API.DBCONTEXT;

namespace Digital_Garage_Solutions_API.Controllers
{
    [ApiController]
    [Route("api/diagnostics")]
        public class DiagnosticsController : ControllerBase
        {
            private readonly DataBase _context;

            public DiagnosticsController(DataBase context)
            {
                _context = context;
            }

            [HttpPost("bookdignostics")]
            public IActionResult BookDiagnostics([FromBody] DiagnosticsBooking booking)
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid booking data");

                _context.DiagnosticsBookings.Add(booking);
                _context.SaveChanges();

                return Ok("Diagnostics booking successful!");
            }
        }
    }


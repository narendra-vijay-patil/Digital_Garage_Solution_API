using Digital_Garage_Solutions_API.DBCONTEXT;
using Digital_Garage_Solutions_API.model;
using Digital_Garage_Solutions_API.viewmodel;
using Digital_Garage_Solutions_API.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace Digital_Garage_Solutions_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GarageController : ControllerBase
    {
        DataBase db;
        public GarageController(DataBase init)
        {
            db = init;
        }


        [HttpPost]
        [Route("PostGarage")]
        public async Task<IActionResult> PostGarageInfo([FromBody]GarageModel model)
        {
            
            var data = new GarageRegistratioinDbModel
            {
                GarageName = model.GarageName,
                MobileEmail = model.MobileEmail,
                Password = model.Password,
                GAddress = model.GAddress,
                GAlternateContact = model.GAlternateContact,
                GCity = model.GCity,
                GClosingTime = TimeOnly.ParseExact(model.GClosingTime, "HH:mm", CultureInfo.InvariantCulture),
                GDistrict = model.GDistrict,
                GEmail = model.GEmail,
                
                GLatitude = model.GLatitude,
                GLongitude = model.GLongitude,
                GMobile = model.GMobile,
                GOpeningTime = TimeOnly.ParseExact(model.GClosingTime, "HH:mm", CultureInfo.InvariantCulture),
                GServices = model.GServices,
                GState = model.GState,
                GVehicles = model.GVehicles,
                GWorkingTypes = model.GWorkingTypes,
                OwnerName = model.OwnerName

            };

            db.GarageRegistration.Add(data);
            await db.SaveChangesAsync();

            return Ok(new
            {
                success = "true"
            });
          
        }

        [HttpPost]
        [Route("IsValid")]
        public async Task<IActionResult> IsValid(GarageloginModel model)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }

            if (await db.GarageRegistration.FirstOrDefaultAsync(c => c.GarageName == model.GarageName && c.MobileEmail == model.MobileEmail && c.Password==model.Password) != null) {

                return Ok(new
                {
                    success = "true",
                    garagename = model.GarageName,
                    garagemobileemail = model.MobileEmail,

                });
                
               
            }
            else
            {
                return Unauthorized("email and password is not correct ");

            }
        }

        [HttpGet]
        [Route("GetGarage")]
        public async Task<IActionResult> getGarage()
        {
           var glist= await db.GarageRegistration.ToListAsync();

            return Ok(glist);
        }
    }
}

using Digital_Garage_Solutions_API.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using Digital_Garage_Solutions_API.DBCONTEXT;

namespace Digital_Garage_Solutions_API.Controllers
{
    
        [ApiController]
        [Route("api/login")]
        public class login_controller : ControllerBase
        {
            private readonly DataBase _context;

            public login_controller(DataBase context)
            {
                _context = context;
            }

            // ================= REGISTER =================
            [HttpPost("register")]
            public IActionResult Register([FromBody] login_model model)
            {
                var userExists =  _context.login.Any(x => x.username == model.username);

                if (userExists)
                    return BadRequest("User already exists, please login");

                _context.login.Add(model);
                _context.SaveChanges();

                return Ok("Registration successful");
            }

        // ================= LOGIN =================
        [HttpPost("login")]
        public IActionResult Login([FromBody] OnlyLoginModel model)
        {
            var user = _context.login
                .FirstOrDefault(x =>
                    x.username == model.username &&
                    x.password == model.password
                );

            if (user == null)
                return Unauthorized("Invalid username or password");

            return Ok(user);
        }
        //[HttpPost("login")]
        //public IActionResult Login([FromBody] login_model model)
        //{
        //    if (model == null || model.Username == null || model.Password == null)
        //        return BadRequest("Invalid payload");

        //    var user = _context.login.FirstOrDefault(x =>
        //        x.Username == model.Username &&
        //        x.Password == model.Password
        //    );

        //    if (user == null)
        //        return Unauthorized("Invalid username or password");

        //    return Ok(new
        //    {
        //        user.Id,
        //        user.Name,
        //        user.Username,
        //        user.Email
        //    });


    }
    }



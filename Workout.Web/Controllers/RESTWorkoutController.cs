using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Workout.Web.Controllers
{
    [ApiController]
    [Route("REST/Workout")]
    [AllowAnonymous]
    public class RESTWorkoutController : ControllerBase
    {
        private readonly IConfiguration _config;
        public RESTWorkoutController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet]
        [Route("test")]
        public IActionResult Test(){
            var output = new { message = "success" };
            return Ok(output);
        }
    }
}
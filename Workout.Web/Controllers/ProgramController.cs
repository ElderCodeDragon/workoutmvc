using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Workout.Web.Controllers
{
    [Route("[controller]")]
    public class ProgramController : Controller
    {
        private readonly ILogger<ProgramController> _logger;

        public ProgramController(ILogger<ProgramController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
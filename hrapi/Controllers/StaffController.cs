using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace hrapi.Controllers {
    [ApiController]
    [Route("staff")]
    public class StaffController : ControllerBase

    {
        public StaffController()
        {
        }

        [HttpGet]
        [Route("test")]
        public async Task<ActionResult> test()
        {
            return Ok("Test");
        }
    }
}

using System;
using System.Threading.Tasks;
using hrapi.Repository;
using hrapi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace hrapi.Controllers
{
    [ApiController]
    [Route("api/authencation")]
    public class AuthenticationController : ControllerBase
    {

        private IStaffRepository _staffRepository;
        IConfiguration _configuration;
        public AuthenticationController(IStaffRepository staffRepository, IConfiguration configuration)
        {
            _staffRepository = staffRepository;
            _configuration = configuration;
        }

        [HttpGet]
        [Route("test")]
        public async Task<ActionResult> test()
        {
            return Ok("Test");
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult> login([FromBody] LoginModel loginModel)
        {
            var staff = await _staffRepository.GetByStaffCode(loginModel.userName);
            if(staff == null)
            {
                return NotFound(false);
            }

            if (!staff.Passwords.Equals(loginModel.passWord))
            {
                return NotFound(false);
            }
            var jwt = new JwtService(_configuration);
            var token = jwt.GenerateSecurityToken(loginModel.userName);

            _ = await _staffRepository.GenerateToken(loginModel.userName,token);
            return Ok(staff);
        }
    }
}

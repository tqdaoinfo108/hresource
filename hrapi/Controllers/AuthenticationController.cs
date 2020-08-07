using System;
using System.Threading.Tasks;
using hrapi.Repository;
using hrapi.Model;
using Microsoft.AspNetCore.Mvc;

namespace hrapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {

        private IStaffRepository _staffRepository;
        public AuthenticationController(IStaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
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

            _ = await _staffRepository.GenerateToken(loginModel.userName);

            return Ok(true);
        }
    }
}

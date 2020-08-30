using System;
using System.Security.Claims;
using System.Threading.Tasks;
using hrapi.Model;
using hrapi.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace hrapi.Controllers {
    
    [ApiController]
    [Authorize]
    [Route("api/staff")]
    public class StaffController : ControllerBase
    {
        private IStaffRepository _staffRepository;
        public StaffController(IStaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }

        [HttpGet]
        [Route("profile")]
        public async Task<ActionResult> getProfile()
        {
            var valueId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            if (valueId == null)
            {
                return NotFound("");
            }
            var value = await _staffRepository.GetById(Int32.Parse(valueId));
            
            return Ok(value);
        }

        [HttpPost]
        [Route("create")]
        public async Task<ActionResult> Create(Staffs staffs)
        {
            var value = await _staffRepository.Create(staffs);
            return Ok(value);
        }

        [HttpPost]
        [Route("update")]
        public async Task<ActionResult> Update(Staffs staffs)
        {
            var value = await _staffRepository.Update(staffs.StaffCode, staffs);
            return Ok(value);
        }
    }
}

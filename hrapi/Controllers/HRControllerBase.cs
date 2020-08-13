using System;
using System.Security.Claims;
using hrapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace hrapi.Controllers
{
    public class HRControllerBase : ControllerBase
    {
        private IStaffRepository _staffRepository;

        public HRControllerBase(IStaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }

        public int GetCurrentID()
        {
            var valueEmail = this.User.FindFirst(ClaimTypes.Email);
            if(valueEmail == null)
            {
                return 0;
            }
            var item = _staffRepository.GetByStaffCode(valueEmail.Value);
            if(item == null)
            {
                return 0;
            }

            return item.Id;
        }
    }
}

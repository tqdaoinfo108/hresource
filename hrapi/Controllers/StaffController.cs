using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using hrapi.Model;
using hrapi.Model.DAO;
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
        private IDepartmentRepository _departmentRepository;
        private ICompanyRepository _companyRepository;
        private IPositionReponsitory _positionReponsitory;


        public StaffController(IStaffRepository staffRepository,
            IDepartmentRepository departmentRepository, ICompanyRepository companyRepository,
            IPositionReponsitory positionReponsitory)
        {
            _staffRepository = staffRepository;
            _departmentRepository = departmentRepository;
            _companyRepository = companyRepository;
            _positionReponsitory = positionReponsitory;
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
            staffs.DateCreated = DateTime.Now;
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

        [HttpGet]
        [Route("delete")]
        public async Task<ActionResult> Delete([FromQuery] int id)
        {
            var value = await _staffRepository.Delete(id);
            return Ok(value);
        }

        [HttpGet]
        [Route("getall")]
        public async Task<ActionResult> GetAll()
        {
            var value = await _staffRepository.GetAll();
            var lstDepartment = await _departmentRepository.GetAll();
            var lstCompany = await _companyRepository.GetAll();
            var lstPosition = await _positionReponsitory.GetAll();

            var valueFull = new List<StaffReponseFullField>();
            foreach(var item in value)
            {
                var itm = new StaffReponseFullField
                {
                    StaffID = item.StaffID,
                    Avatar = item.Avatar,
                    StaffCode = item.StaffCode,
                    FullName = item.FullName,
                    StatusID = item.StatusID,
                    DateCreated = item.DateCreated,
                    LastLogin = item.LastLogin,
                    CompanyName = lstCompany.Where(x => x.CompanyID == item.CompanyID).FirstOrDefault().CompanyName,
                    DepartmentsName = lstDepartment.Where(x => x.DepartmentID == item.DepartmentsID).FirstOrDefault().DepartmentName,
                    PositionsName = lstPosition.Where(x => x.PositionID == item.PositionsID).FirstOrDefault().PositionName
                };

                valueFull.Add(itm);
            }
            return Ok(valueFull);
        }
    }
}

using System;
using System.Threading.Tasks;
using hrapi.Model;
using hrapi.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace hrapi.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/department")]
    public class DepartmentsController : ControllerBase
    {
        private IDepartmentRepository _departmentRepository;
        public DepartmentsController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        [HttpPost]
        [Route("create")]
        public async Task<ActionResult> Create(Departments value)
        {
            var result = await _departmentRepository.Create(value);
            return Ok(result);
        }

        [HttpGet]
        [Route("delete")]
        public async Task<ActionResult> Delete([FromQuery] int id)
        {
            var value = await _departmentRepository.Delete(id);
            return Ok(value);
        }
    }
}

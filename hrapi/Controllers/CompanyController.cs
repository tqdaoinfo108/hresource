using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hrapi.Model;
using hrapi.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace hrapi.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/company")]
    public class CompanyController : ControllerBase
    {
        private ICompanyRepository _companyRepository;
        public CompanyController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        [HttpPost]
        [Route("create")]
        public async Task<ActionResult> create([FromBody] CompanysCreate value)
        {
            int id = await _companyRepository.Create(new Companys {
                Logo = value.Logo,
                CompanyName = value.CompanyName,
                CompanyDescription = value.CompanyDescription,
                Address = value.Address,
                Phone = value.Phone,
                DateCreated = DateTime.Now
            });
            return Ok(id);
        }

        [HttpGet]
        [Route("get")]
        public async Task<ActionResult> get()
        {
            var companyID = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (companyID == null)
            {
                return NotFound("");
            }
            var value = await _companyRepository.GetById(Int32.Parse(companyID));

            return Ok(value);
        }

        [HttpGet]
        [Route("getAll")]
        public async Task<ActionResult> getAll()
        {
            var value = await _companyRepository.GetAll();
            return Ok(value);
        }
    }
}

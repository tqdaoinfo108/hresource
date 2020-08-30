using System;
using System.Security.Claims;
using System.Threading.Tasks;
using hrapi.Model;
using hrapi.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace hrapi.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/news")]
    public class NewsController : ControllerBase
    {
        private INewsRepository _newsRepository;
        private IStaffRepository _staffRepository;


        public NewsController(INewsRepository newsRepository, IStaffRepository staffRepository)
        {
            _newsRepository = newsRepository;
            _staffRepository = staffRepository;
        }

        [HttpPost]
        [Route("create")]
        public async Task<ActionResult> create([FromBody] News value)
        {
            var lstStaff = await _staffRepository.GetAll();
            var valueId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var valueName = this.User.FindFirst(ClaimTypes.Name).Value;

            if (valueId == null)
            {
                return NotFound("");
            }

            foreach (var item in lstStaff)
            {
                await _newsRepository.CreateNews(new News
                {
                    Title = value.Title,
                    Description = value.Description,
                    DateCreated = DateTime.Now,
                    UserCreated = Int32.Parse(valueId),
                    UserCreatedName = valueName,
                    IsSeen = false,
                    StaffID = item.StaffID,
                    CategoryNewsID = value.CategoryNewsID
                });
            }
            
            return Ok(true);
        }

    }
}

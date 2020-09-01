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
    public class PositionsController : ControllerBase
    {
        private IPositionReponsitory _postionRepository;
        public PositionsController(IPositionReponsitory postionRepository)
        {
            _postionRepository = postionRepository;
        }

        [HttpPost]
        [Route("create")]
        public async Task<ActionResult> Create(Positions value)
        {
            var result = await _postionRepository.Create(value);
            return Ok(result);
        }


        [HttpGet]
        [Route("delete")]
        public async Task<ActionResult> Delete([FromQuery] int id)
        {
            var value = await _postionRepository.Delete(id);
            return Ok(value);
        }

    }
}

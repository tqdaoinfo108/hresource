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
    [Route("api/todolist")]
    public class ToDoListController : ControllerBase
    {
        private IToDoListsRepository _toDoListsRepository;

        public ToDoListController(IToDoListsRepository toDoListsRepository)
        {
            _toDoListsRepository = toDoListsRepository; ;
        }

        [HttpPost]
        [Route("create")]
        public async Task<ActionResult> Create(ToDoLists value)
        {
            var result = await _toDoListsRepository.Create(value);
            return Ok(result);
        }


        [HttpGet]
        [Route("delete")]
        public async Task<ActionResult> Delete([FromQuery] int id)
        {
            var value = await _toDoListsRepository.Delete(id);
            return Ok(value);
        }

        [HttpGet]
        [Route("changestate")]
        public async Task<ActionResult> ChangeStateTodolist([FromQuery] int id)
        {
            var value = await _toDoListsRepository.ChangeStateTodoList(id);
            return Ok(value);
        }

        [HttpPost]
        [Route("update")]
        public async Task<ActionResult> Update(ToDoLists value)
        {
            var result = await _toDoListsRepository.Update(value);
            return Ok(value.ToDoListID);
        }
    }
}

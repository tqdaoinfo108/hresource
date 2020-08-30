using System;
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
    }
}

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

namespace hrapi.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/todolist")]
    public class ToDoListController : ControllerBase
    {
        private IToDoListsRepository _toDoListsRepository;
        private IStaffRepository _staffRepository;
        private IDepartmentRepository _departmentRepository;
        public ToDoListController(IToDoListsRepository toDoListsRepository, IStaffRepository staffRepository,
            IDepartmentRepository departmentRepository)
        {
            _toDoListsRepository = toDoListsRepository;
            _staffRepository = staffRepository;
            _departmentRepository = departmentRepository;
        }

        [HttpPost]
        [Route("create")]
        public async Task<ActionResult> Create(ToDoLists value)
        {
            var valueId =  this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            if (valueId == null)
            {
                return NotFound("");
            }
            value.DateCreated = DateTime.Now;
            value.UserCreatedID = Int32.Parse(valueId);
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

        [HttpGet]
        [Route("getall")]
        public async Task<ActionResult> GetAll()
        {
            var value = await _toDoListsRepository.GetAll();
            var lstStaff = await _staffRepository.GetAll();
            var lstDepartment = await _departmentRepository.GetAll();


            var valueResult = new List<ToDoListResponse>();
            foreach (var item in value)
            {
                valueResult.Add(new ToDoListResponse
                {
                    ToDoListID = item.ToDoListID,
                    Title = item.Title,
                    Description = item.Description,
                    Priority = item.Priority,
                    TimeStart = item.TimeStart,
                    TimeEnd = item.TimeEnd,
                    UserCreatedName = lstStaff.Where(x => x.StaffID == item.UserCreatedID).FirstOrDefault().FullName,
                    DateCreated = item.DateCreated,
                    StaffAssignedName = lstStaff.Where(x => x.StaffID == item.StaffAssignedID).FirstOrDefault().FullName,
                    IsComplete = item.IsComplete,
                    DepartmentName = item.Departments.DepartmentName
                });
            }

            return Ok(valueResult);
        }

        [HttpGet]
        [Route("department")]
        public async Task<ActionResult> GetFromDepartm([FromQuery] int id)
        {
            var lstTOdoList = await _toDoListsRepository.GetAll();
            var lstDepartment = await _departmentRepository.GetAll();
            var lstStaff = await _staffRepository.GetAll();

            var lstResult = new List<ToDoListResponse>();
            foreach (var item in lstTOdoList)
            {
                if(item.DepartmentsID == id)
                {
                    lstResult.Add(new ToDoListResponse
                    {
                        ToDoListID = item.ToDoListID,
                        Title = item.Title,
                        Description = item.Description,
                        Priority = item.Priority,
                        TimeStart = item.TimeStart,
                        TimeEnd = item.TimeEnd,
                        UserCreatedName = lstStaff.Where(x => x.StaffID == item.UserCreatedID).FirstOrDefault().FullName,
                        DateCreated = item.DateCreated,
                        StaffAssignedName = lstStaff.Where(x => x.StaffID == item.StaffAssignedID).FirstOrDefault().FullName,
                        IsComplete = item.IsComplete,
                        DepartmentName = item.Departments.DepartmentName
                    });
                }
            }
            return Ok(lstResult);
        }

    }
}

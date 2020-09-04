using System;
using System.Collections.Generic;
using System.Linq;
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
    [Route("api/dashboard")]
    public class DashboardController : ControllerBase
    {
        private IStaffRepository _staffRepository;
        private IDepartmentRepository _departmentRepository;
        private IToDoListsRepository _toDoListsRepository;

        public DashboardController(IStaffRepository staffRepository, IToDoListsRepository toDoListsRepository,
            IDepartmentRepository departmentRepository)
        {
            _staffRepository = staffRepository;
            _departmentRepository = departmentRepository;
            _toDoListsRepository = toDoListsRepository;
        }

        [HttpGet]
        [Route("get")]
        public async Task<ActionResult> Get()
        {
            var lstStaff =  await _staffRepository.GetAll();
            var lstDepartment = await _departmentRepository.GetAll();
            var lstToDoList = await _toDoListsRepository.GetAll();

            var result = new DashboardResponse
            {
                TotalTodolistProcessing = lstToDoList.Where(x => x.IsComplete == false).Count(),
                TotalTodolistLate = lstToDoList.Where(x => x.IsComplete && DateTime.Compare((DateTime)x.TimeEnd, DateTime.Now) == 1).Count(),
                TotalTodolistComplete = lstToDoList.Where(x => x.IsComplete == true).Count(),
                TotalCalendarExpected = 0,
                TotalCalendarComplete = 0,
                TotalCalendar = 0,
                TotalStaff = lstStaff.Count(),
                TotalDepartment = lstDepartment.Count(),
                TotalToDoList = lstToDoList.Count()
            };

            return Ok(result);
        }

        [HttpGet]
        [Route("gettask")]
        public async Task<ActionResult> GetTask()
        {
            var lstToDoList = await _toDoListsRepository.GetAll();
            var lstStaff = await _staffRepository.GetAll();
            var lstDepartment = await _departmentRepository.GetAll();

            var valueResult = new List<ToDoListResponse>();
            int count = 0;
            foreach (var item in lstToDoList)
            {
                if(count > 4) { break; }
                valueResult.Add(new ToDoListResponse
                {
                    ToDoListID = item.ToDoListID,
                    Title = item.Title,
                    Description = item.Description,
                    StatusID = item.StatusID,
                    Priority = item.Priority,
                    TimeStart = item.TimeStart,
                    TimeEnd = item.TimeEnd,
                    UserCreatedName = lstStaff.Where(x => x.StaffID == item.UserCreatedID).FirstOrDefault().FullName,
                    DateCreated = item.DateCreated,
                    StaffAssignedName = lstStaff.Where(x => x.StaffID == item.StaffAssignedID).FirstOrDefault().FullName,
                    IsComplete = item.IsComplete,
                    DepartmentName = lstDepartment.Where(x => x.DepartmentID == item.DepartmentsID).FirstOrDefault().DepartmentName,
                });
                count++;

            }
            return Ok(valueResult);
        }

        [HttpGet]
        [Route("getDepartment")]
        public async Task<ActionResult> GetDepartment()
        {
            var lstToDoList = await _toDoListsRepository.GetAll();
            var lstStaff = await _staffRepository.GetAll();
            var lstDepartment = await _departmentRepository.GetAll();

            var valueResult = new List<DepartmentRespones>();

            var value = lstToDoList.GroupBy(x => x.DepartmentsID);
            foreach(var item in value)
            {
                var value1 = item.ToList<ToDoLists>();
            }
           
            return Ok(valueResult);
        }
    }

}

using System;
namespace hrapi.Model.DAO
{
    public class ToDoListResponse
    {
        public int ToDoListID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int StatusID { get; set; }
        public int Priority { get; set; }
        public Nullable<System.DateTime> TimeStart { get; set; }
        public Nullable<System.DateTime> TimeEnd { get; set; }
        public string UserCreatedName { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public string StaffAssignedName { get; set; }
        public bool IsComplete { get; set; }

        public string DepartmentName { get; set; }
    }

}
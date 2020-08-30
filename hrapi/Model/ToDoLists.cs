using System;
using System.ComponentModel.DataAnnotations;

namespace hrapi.Model
{
    public class ToDoLists
    {
        [Key]
        public int ToDoListID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int StatusID { get; set; }
        public int Priority { get; set; }
        public Nullable<System.DateTime> TimeStart { get; set; }
        public Nullable<System.DateTime> TimeEnd { get; set; }
        public int UserCreatedID { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public int StaffAssignedID;

        public int? DepartmentsID { get; set; }
        public Departments Departments { get; set; }
    }
}
    
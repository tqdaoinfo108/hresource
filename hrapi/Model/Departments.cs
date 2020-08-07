using System;
using System.ComponentModel.DataAnnotations;

namespace hrapi.Model
{
    public class Departments
    {
        public Departments()
        {
        }
        [Key]
        public int DepartmentID { get; set; }
        public Nullable<int> ParentDepartmentID { get; set; }
        public bool IsRootDepartment { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }
        public int StatusID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public string UserCreated { get; set; }
        public string UserUpdated { get; set; }

        public Companys CompanyID { get; set; }

    }
}

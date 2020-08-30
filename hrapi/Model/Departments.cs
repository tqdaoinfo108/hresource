using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hrapi.Model
{
    public class Departments
    {
        [Key]
        public int DepartmentID { get; set; }
        public Nullable<int> ParentDepartmentID { get; set; }
        public bool IsRootDepartment { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public string UserCreated { get; set; }


        public int? CompanyID { get; set; }
        public Companys Company { get; set; }

    }
}

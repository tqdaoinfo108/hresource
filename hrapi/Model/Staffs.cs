using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hrapi.Model
{
    public class Staffs
    {
        [Key]
        public int StaffID { get; set; }
        public string Avatar { get; set; }
        public string StaffCode { get; set; }
        public string Passwords { get; set; }
        public string FullName { get; set; }
        public int StatusID { get; set; }
        public Nullable<System.DateTime>  DateCreated { get; set; }
        public Nullable<System.DateTime> DateOut { get; set; }

        public Nullable<System.DateTime> LastLogin { get; set; }
        public string Token { get; set; }

        public int? CompanyID { get; set; }
        public Companys Company { get; set; }

        public int? PositionsID { get; set; }
        public Positions Positions { get; set; }

        public int? DepartmentsID { get; set; }
        public Departments Departments { get; set; }

    }
}

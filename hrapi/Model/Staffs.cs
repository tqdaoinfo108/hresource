using System;
using System.ComponentModel.DataAnnotations;

namespace hrapi.Model
{
    public class Staffs
    {
        [Key]
        public int StaffID { get; set; }
        public string StaffCode { get; set; }
        public string Passwords { get; set; }
        public string FullName { get; set; }
        public int StatusID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public string UserCreated { get; set; }
        public string UserUpdated { get; set; }
        public Nullable<System.DateTime> LastLogin { get; set; }
        public string Token { get; set; }

        public Companys CompanysID { get; set; }
        public Positions PositionsID { get; set; }
        public Departments DepartmentsID { get; set; }
    }
}

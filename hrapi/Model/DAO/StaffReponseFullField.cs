using System;
namespace hrapi.Model.DAO
{
    public class StaffReponseFullField
    {
        public int StaffID { get; set; }
        public string Avatar { get; set; }
        public string StaffCode { get; set; }
        public string FullName { get; set; }
        public int StatusID { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> LastLogin { get; set; }

        public string CompanyName { get; set; }

        public string PositionsName { get; set; }

        public string DepartmentsName { get; set; }
    }
}

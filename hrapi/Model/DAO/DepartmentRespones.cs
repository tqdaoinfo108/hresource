using System;
namespace hrapi.Model.DAO
{
    public class DepartmentRespones
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public int isProcess { get; set; }
        public int isComplete { get; set; }
        public int isToTal { get; set; }
    }
}

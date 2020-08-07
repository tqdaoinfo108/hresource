using System;
using System.ComponentModel.DataAnnotations;

namespace hrapi.Model
{
    public class Groups
    {
        public Groups()
        {
        }

        [Key]
        public int GroupID { get; set; }
        public int CompanyID { get; set; }
        public string GroupName { get; set; }
        public string GroupDescription { get; set; }
        public int StatusID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public string UserCreated { get; set; }
        public string UserUpdated { get; set; }
    }
}

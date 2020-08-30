using System;
using System.ComponentModel.DataAnnotations;

namespace hrapi.Model
{
    public class Events
    {
        [Key]
        public int EventID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int StatusID { get; set; }
        public Nullable<System.DateTime> TimeStart { get; set; }
        public Nullable<System.DateTime> TimeEnd { get; set; }
        public int UserCreatedID { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }

        public int? CompanyID { get; set; }
        public Companys Company { get; set; }
    }
}

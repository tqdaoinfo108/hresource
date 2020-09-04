using System;
using System.ComponentModel.DataAnnotations;

namespace hrapi.Model
{
    public class Events
    {
        [Key]
        public int EventID { get; set; }
        public int CompanyID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int StatusID { get; set; }
        public System.DateTime TimeStart { get; set; }
        public System.DateTime TimeEnd { get; set; }
        public int UserHostID { get; set; }
        public System.DateTime DateCreated { get; set; }
    }
}
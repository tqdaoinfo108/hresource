using System;
using System.ComponentModel.DataAnnotations;

namespace hrapi.Model
{
    public class BookingEvent
    {
        public BookingEvent()
        {
        }

        [Key]
        public int EventID { get; set; }
        public int CompanyID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int StatusID { get; set; }
        public System.DateTime TimeStart { get; set; }
        public System.DateTime TimeEnd { get; set; }
        public string ActionUrl { get; set; }
        public string ColorCode { get; set; }
        public int UserHostID { get; set; }
        public int UserCreatedID { get; set; }
        public int UserUpdatedID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool IsReminded { get; set; }
    }
}

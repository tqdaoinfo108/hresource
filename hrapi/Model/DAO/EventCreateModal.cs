using System;
using System.Collections.Generic;

namespace hrapi.Model.DAO
{
    public class EventCreateModal
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public List<string> ListAttendance { get; set; }
        public List<string> ListCatagories { get; set; }

    }
}


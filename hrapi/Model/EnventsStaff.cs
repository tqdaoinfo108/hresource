using System;
using System.ComponentModel.DataAnnotations;

namespace hrapi.Model
{
    public class EnventsStaff
    {
        [Key]
        public int StaffEventID { get; set; }

        public int StaffID { get; set; }
        public Staffs Staff { get; set; }

        public int EventID { get; set; }
        public Events Event { get; set; }

        public int status { get; set; }
    }
}

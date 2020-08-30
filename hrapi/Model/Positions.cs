using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hrapi.Model
{
    public class Positions
    {
        [Key]
        public int PositionID { get; set; }
        public string PositionName { get; set; }
        public string PositionDescription { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public string UserCreated { get; set; }

        public int? CompanyID { get; set; }
        public Companys Company { get; set; }
    }
}

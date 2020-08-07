using System;
using System.ComponentModel.DataAnnotations;

namespace hrapi.Model
{
    public class Positions
    {
        public Positions()
        {
        }

        [Key]
        public int PositionID { get; set; }
        public int CompanyID { get; set; }
        public string PositionName { get; set; }
        public string PositionDescription { get; set; }
        public int StatusID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public string UserCreated { get; set; }
        public string UserUpdated { get; set; }
    }
}

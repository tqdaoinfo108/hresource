using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hrapi.Model
{
    public class News
    {
        [Key]
        public int NewsID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public int  UserCreated { get; set; }
        public string UserCreatedName { get; set; }
        public bool IsSeen { get; set; }

        public int? StaffID { get; set; }
        public Staffs Staff { get; set; }

        public int? CategoryNewsID { get; set; }
        public NewsCategory CategoryNews { get; set; }
    }

    public class CreateNews
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int UserCreated { get; set; }
        public string UserCreatedName { get; set; }
        public NewsCategory CategoryNewsID { get; set; }
        public String CategoryNewName { get; set; }
    }
}

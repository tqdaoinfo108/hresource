using System;
using System.ComponentModel.DataAnnotations;

namespace hrapi.Model
{
    public class News
    {
        public News()
        {
        }

        [Key]
        public int NewsID { get; set; }
        public string Title { get; set; }
        public int StatusID { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public string UserCreated { get; set; }
        public string UserUpdated { get; set; }

        public NewsCategory CategoryNewsID { get; set; }

    }
}

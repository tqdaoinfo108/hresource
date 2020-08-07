using System;
using System.ComponentModel.DataAnnotations;

namespace hrapi.Model
{
    public class NewsCategory
    {
        public NewsCategory()
        {
        }
        [Key]
        public int CategoryNewsID { get; set; }
        public int StatusID { get; set; }
        public int Order { get; set; }
        public string CategoryNewsTitle { get; set; }
        public string CategoryNewsDescription { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public string UserCreated { get; set; }
        public string UserUpdated { get; set; }

        public Companys CompanyID { get; set; }
    }
}

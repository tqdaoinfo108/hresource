using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hrapi.Model
{
    public class NewsCategory
    {
        [Key]
        public int CategoryNewsID { get; set; }
        public int StatusID { get; set; }
        public string CategoryNewsTitle { get; set; }
        public string CategoryNewsDescription { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public string UserCreated { get; set; }

        public int? CompanyID { get; set; }
        public Companys Company { get; set; }
    }
}

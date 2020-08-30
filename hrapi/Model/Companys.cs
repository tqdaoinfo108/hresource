using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace hrapi.Model
{
    public class Companys
    {
        [Key]
        public int CompanyID { get; set; }
        public string Logo { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDescription { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }

        public bool States { get; set; }

    }

    public class CompanysCreate
    {
        public string Logo { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDescription { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int StatusID { get; set; }
        public System.DateTime DateCreated { get; set; }
    }
}


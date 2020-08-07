using System;
using System.ComponentModel.DataAnnotations;

namespace hrapi.Model
{
    public class Companys
    {
        public Companys() {  }

        [Key]
        public int CompanyID { get; set; }
        public string Logo { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDescription { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int StatusID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public string UserCreated { get; set; }
        public string UserUpdated { get; set; }
        public string TaxNumber { get; set; }
    }
}


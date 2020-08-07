using System;
using System.ComponentModel.DataAnnotations;

namespace hrapi.Model
{
    public class States
    {
       
        [Key]
        public int StatesID { get; set; }
        public string StateName { get; set; }
    }
}

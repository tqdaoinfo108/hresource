using System;
using System.ComponentModel.DataAnnotations;

namespace hrapi.Model
{
    public class Catagories
    {
        [Key]
        public int CatagoriesID { get; set; }
        public string Name { get; set; }

        public string Desciption { get; set; }
        public int Status { get; set; }
    }
}

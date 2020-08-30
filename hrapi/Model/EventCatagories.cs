using System;
using System.ComponentModel.DataAnnotations;

namespace hrapi.Model
{
    public class EventCatagories
    {
        [Key]
        public int EventCatagoriesID { get; set; }

        public int? EventID { get; set; }
        public Events Events { get; set; }

        public int? CatagoriesID { get; set; }
        public Catagories Catagory { get; set; }
    }
}

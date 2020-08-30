using System;
using System.ComponentModel.DataAnnotations;

namespace hrapi.Model
{
    public class Comments
    {
        [Key]
        public int CommentsID { get; set; }
        public string Content { get; set; }
        public Nullable<System.DateTime> DateTimeCreate { get; set; }
        public string UserCreateName { get; set; }

        public int? ToDoListsID { get; set; }
        public ToDoLists ToDoLists { get; set; }
    }
}

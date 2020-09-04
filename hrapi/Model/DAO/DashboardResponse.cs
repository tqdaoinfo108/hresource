using System;
namespace hrapi.Model.DAO
{
    public class DashboardResponse
    {
            public int TotalTodolistProcessing { get; set; }
            public int TotalTodolistLate { get; set; }
            public int TotalTodolistComplete { get; set; }


            public int TotalCalendarExpected { get; set; }
            public int TotalCalendarComplete { get; set; }
            public int TotalCalendar { get; set; }

            public int TotalStaff { get; set; }
            public int TotalDepartment { get; set; }
            public int TotalToDoList { get; set; }

    }
}

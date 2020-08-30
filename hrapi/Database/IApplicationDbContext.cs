using System;
using System.Threading.Tasks;
using hrapi.Model;
using Microsoft.EntityFrameworkCore;

namespace hrapi.Database
{
    public interface IApplicationDbContext
    {
        DbSet<States> states { get; set; }
        DbSet<Companys> companys { get; set; }
        DbSet<News> news { get; set; }
        DbSet<NewsCategory> newsCategories { get; set; }
        DbSet<Positions> positions { get; set; }
        DbSet<Staffs> staffs { get; set; }
        DbSet<Departments> departments { get; set; }

        DbSet<ToDoLists> toDoLists{ get; set; }
        DbSet<Comments> comments { get; set; }
        DbSet<Events> events { get; set; }
        DbSet<Catagories> Catagories { get; set; }
        DbSet<EventCatagories> eventCatagories { get; set; }
        DbSet<EnventsStaff> enventsStaff { get; set; }

        Task<int> SaveChanges();
    }
}

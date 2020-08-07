using System;
using System.Threading.Tasks;
using hrapi.Model;
using Microsoft.EntityFrameworkCore;

namespace hrapi.Database
{
    public interface IApplicationDbContext
    {
        DbSet<BookingEvent> bookingEvents { get; set; }
        DbSet<Companys> companys { get; set; }
        DbSet<Groups> groups { get; set; }
        DbSet<News> news { get; set; }
        DbSet<NewsCategory> newsCategories { get; set; }
        DbSet<Positions> positions { get; set; }
        DbSet<Staffs> staffs { get; set; }

        Task<int> SaveChanges();
    }
}

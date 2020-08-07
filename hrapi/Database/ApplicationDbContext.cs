using System;
using System.Threading.Tasks;
using hrapi.Model;
using Microsoft.EntityFrameworkCore;

namespace hrapi.Database
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<States> states { get; set; }
        public DbSet<BookingEvent> bookingEvents { get ; set ; }
        public DbSet<Companys> companys { get ; set ; }
        public DbSet<Groups> groups { get ; set ; }
        public DbSet<News> news { get ; set ; }
        public DbSet<NewsCategory> newsCategories { get ; set ; }
        public DbSet<Positions> positions { get ; set ; }
        public DbSet<Staffs> staffs { get ; set ; }

        public new async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }
}

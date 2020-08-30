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
        public DbSet<Companys> companys { get ; set ; }
        public DbSet<News> news { get ; set ; }
        public DbSet<NewsCategory> newsCategories { get ; set ; }
        public DbSet<Positions> positions { get ; set ; }
        public DbSet<Staffs> staffs { get ; set ; }
        public DbSet<Departments> departments { get; set; }
        public DbSet<ToDoLists> toDoLists { get; set; }
        public DbSet<Comments> comments { get; set; }
        public DbSet<Events> events { get; set; }
        public DbSet<Catagories> Catagories { get; set; }
        public DbSet<EventCatagories> eventCatagories { get; set; }
        public DbSet<EnventsStaff> enventsStaff { get; set; }

        public new async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Companys>().HasKey(table => new {
            //    table.StStatesID,
            //    table.States
            //});

            //modelBuilder.Entity<News>()
            //            .HasOne(e => e.Staff)
            //            .WithMany()
            //            .IsRequired(false);

            //modelBuilder.Entity<News>()
            //            .HasOne(e => e.CategoryNews)
            //            .WithMany()
            //            .IsRequired(false);
            ////modelBuilder.Entity<Departments>().HasKey(table => new {
            ////    table.,
            ////    table.Company
            ////});

            //modelBuilder.Entity<News>().HasKey(table => new {
            //    table.StaffID,
            //    table.Staff
            //});

            //modelBuilder.Entity<News>().HasKey(table => new {
            //    table.CategoryNewsID,
            //    table.CategoryNews
            //});

            //modelBuilder.Entity<NewsCategory>().HasKey(table => new {
            //    table.CompanyID,
            //    table.Company
            //});

            //modelBuilder.Entity<Positions>().HasKey(table => new {
            //    table.CompanyID,
            //    table.Company
            //});

            //modelBuilder.Entity<Staffs>().HasKey(table => new {
            //    table.CompanyID,
            //    table.Company
            //});

            //modelBuilder.Entity<Staffs>().HasKey(table => new {
            //    table.PositionsID,
            //    table.Positions
            //});

            //modelBuilder.Entity<Staffs>().HasKey(table => new {
            //    table.DepartmentsID,
            //    table.Departments
            //});
            base.OnModelCreating(modelBuilder);

        }
    }
}

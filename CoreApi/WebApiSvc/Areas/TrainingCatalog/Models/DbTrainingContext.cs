using System.Data.Entity;
using System.Web.Providers.Entities;

namespace WebApiSvc.Areas.TrainingCatalog.Models
{
    public class DbTrainingContext : DbContext
    {
        public DbTrainingContext()
            : base("TrainingDB")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;

        }



        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Template> Templates { get; set; }  



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoursesTaking>().HasKey(s => new {s.CourseId, s.StudentId});
            modelBuilder.Entity<CoursesTeaching>().HasKey(s => new { s.CourseId, s.TeacherId });
        }
    }
}
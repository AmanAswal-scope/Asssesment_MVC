using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Context
{
    public class UDbContext :DbContext
    {
        public UDbContext()
        {

        }
        public UDbContext(DbContextOptions<UDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }

        public DbSet<Batch> Batches { get; set; }

        public DbSet<Course> Courses { get; set; }
        public DbSet<WebApplication1.Models.Course>? Course { get; set; }
        public DbSet<WebApplication1.Models.Batch>? Batch { get; set; }
        public DbSet<WebApplication1.Models.LoginPage>? LoginPage { get; set; }
    }
}

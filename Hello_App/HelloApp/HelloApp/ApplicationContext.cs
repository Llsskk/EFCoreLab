using HelloApp;
using Microsoft.EntityFrameworkCore;
namespace DemoAppCRUD
{
    class ApplicationContext : DbContext
    {
        public DbSet<User>Users { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
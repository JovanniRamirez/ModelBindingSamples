using Microsoft.EntityFrameworkCore;

namespace ModelBindingSamples.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        // Add a DbSet for each entity to be tracked by the context
        // The context will create tables for each DBSet and
        // create migrations to update the database schema
        public DbSet<Student> Students { get; set; }
    }
}
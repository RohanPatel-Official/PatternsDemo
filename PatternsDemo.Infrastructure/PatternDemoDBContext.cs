using Microsoft.EntityFrameworkCore;
using PatternsDemo.Domain.DBModels;

namespace PatternsDemo.Infrastructure
{
    public class PatternDemoDBContext : DbContext
    {
        public PatternDemoDBContext(DbContextOptions<PatternDemoDBContext> options)
            : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}

using Microsoft.EntityFrameworkCore;
using PatternsDemo.Domain.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsDemo.Infrastructure
{
    public class PatternDemoDBContext : DbContext
    {
        public PatternDemoDBContext(DbContextOptions<PatternDemoDBContext> options)
            : base(options)
        {
        }

        public DbSet<Users> User { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}

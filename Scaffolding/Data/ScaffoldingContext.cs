using Microsoft.EntityFrameworkCore;
using Scaffolding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scaffolding.Data
{
    public class ScaffoldingContext : DbContext
    {
        public ScaffoldingContext(DbContextOptions<ScaffoldingContext> options) : base(options) { }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}

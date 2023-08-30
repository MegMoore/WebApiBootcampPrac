using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiBootcampPrac.Models;

namespace WebApiBootcampPrac.Data
{
    public class WebApiBootcampPracContext : DbContext
    {
        public WebApiBootcampPracContext (DbContextOptions<WebApiBootcampPracContext> options)
            : base(options)
        {
        }

        public DbSet<Assessment> Assessments { get; set; } = default!;

        public DbSet<Student> Student { get; set; } = default!;

        public DbSet<Score> Score { get; set; } = default!;
    }
}

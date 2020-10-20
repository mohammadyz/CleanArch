using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data.Context
{
    public class CleanArchDbContext : DbContext
    {
        public CleanArchDbContext(DbContextOptions<CleanArchDbContext> options) :
            base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
    }
}

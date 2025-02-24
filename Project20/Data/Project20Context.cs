using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project20.Models;

namespace Project20.Data
{
    public class Project20Context : DbContext
    {
        public Project20Context (DbContextOptions<Project20Context> options)
            : base(options)
        {
        }

        public DbSet<Project20.Models.Department> Department { get; set; } = default!;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectRest.Models;

namespace ProjectRest.Models
{
    public class ProjectRestContext : DbContext
    {
        public ProjectRestContext (DbContextOptions<ProjectRestContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectRest.Models.City> City { get; set; }

        public DbSet<ProjectRest.Models.Menu> Menu { get; set; }

        public DbSet<ProjectRest.Models.Order> Order { get; set; }
    }
}

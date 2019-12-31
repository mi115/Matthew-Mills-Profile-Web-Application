using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Matthew_Mills_Profile_Project.Models;

namespace Matthew_Mills_Profile_Project.Data
{
    public class ProjectsContext : DbContext
    {
        public ProjectsContext (DbContextOptions<ProjectsContext> options)
            : base(options)
        {

        }

        public DbSet<Project> Project { get; set; }
    }
}

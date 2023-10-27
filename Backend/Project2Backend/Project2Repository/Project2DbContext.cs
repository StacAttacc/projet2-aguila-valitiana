using Microsoft.EntityFrameworkCore;
using Project2Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2Repository
{
    public class Project2DbContext : DbContext
    {
        public Project2DbContext(DbContextOptions<Project2DbContext> options)
        {

        }

        public virtual DbSet<UpdateEntry> UpdateEntries { get; set; }
    }
}

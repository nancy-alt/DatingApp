using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        //constructor
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        //table user of type appuser which means it has 2 attributes id and name
        public DbSet<AppUser> Users { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EMSFullStack.Models;

namespace EMSFullStack.Data
{
    public class EMSDbContext : DbContext
    {
        public EMSDbContext (DbContextOptions<EMSDbContext> options)
            : base(options)
        {
        }

        public DbSet<EMSFullStack.Models.EmpProfile> EmpProfile { get; set; } = default!;
    }
}

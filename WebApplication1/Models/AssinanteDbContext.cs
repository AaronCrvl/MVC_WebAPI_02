using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class AssinanteDbContext : DbContext
    {
        public AssinanteDbContext(DbContextOptions<AssinanteDbContext> options) : base(options) {}

        public DbSet<AssinanteModel> Assinante { get; set; }
    }
}

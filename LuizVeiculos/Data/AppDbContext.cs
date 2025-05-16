using LuizVeiculos.Models;
using Microsoft.EntityFrameworkCore;

namespace LuizVeiculos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {            
        }

        public DbSet<Cor> Cores { get; set; }
    }
}
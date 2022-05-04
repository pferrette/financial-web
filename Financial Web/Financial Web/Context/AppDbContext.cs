using Financial_Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Financial_Web.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Gasto> Gastos { get; set; }
        public DbSet<Ganho> Ganhos { get; set; }
    }
}

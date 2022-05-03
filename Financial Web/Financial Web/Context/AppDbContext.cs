using Microsoft.EntityFrameworkCore;

namespace Financial_Web.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options) : base(options)
        {
        }
    }
}

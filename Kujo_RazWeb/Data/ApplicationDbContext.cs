using Kujo_RazWeb.Model;
using Microsoft.EntityFrameworkCore;

namespace Kujo_RazWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Category { get; set; }
    }
}

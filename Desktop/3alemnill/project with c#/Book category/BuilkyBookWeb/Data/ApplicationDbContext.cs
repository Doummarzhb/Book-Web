using BuilkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BuilkyBookWeb.Data
{
    public class ApplicationDbContext: DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 

        }
        public DbSet<Category> Categories { get; set; }

    }
}

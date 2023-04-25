using Microsoft.EntityFrameworkCore;
using WebApiApp.Models;

namespace WebApiApp.Data

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users_ { get; set; }
    }
}

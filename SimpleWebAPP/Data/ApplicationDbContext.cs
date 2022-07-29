using Microsoft.EntityFrameworkCore;
using SimpleWebAPP.Models;

namespace SimpleWebAPP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // Create a category table named Categories
        // Find this table outline in Models/Category.cs
        // Creates DB in code
        public DbSet<Category> Categories { get; set; }
    }
}

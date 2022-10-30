using BManager.Models;
using Microsoft.EntityFrameworkCore;

namespace BManager.Data
{
    public class BManagerDbContext : DbContext
    {
        public DbSet<Person> Persons { get;set; }
        public BManagerDbContext(DbContextOptions options) :base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

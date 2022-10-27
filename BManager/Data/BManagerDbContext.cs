using Microsoft.EntityFrameworkCore;

namespace BManager.Data
{
    public class BManagerDbContext : DbContext
    {
        public BManagerDbContext(DbContextOptions options) :base(options) 
        {

        }
    }
}

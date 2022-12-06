using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    // dependency injection
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) 
        {

        } 

        public DbSet<AppUser> Users {get; set;} // predstavlja tabelu unutar baze
    }
}
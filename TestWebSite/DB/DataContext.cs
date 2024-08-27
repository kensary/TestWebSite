using Microsoft.EntityFrameworkCore;
using TestWebSite.Models;

namespace TestWebSite.DB
{
    public class DataContext : DbContext
    {
        public DbSet<UsersAc> UsersAca { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;
using API.Entities;
namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<AppUser> User { get; set; }
    }
}
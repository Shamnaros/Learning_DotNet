using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Shared
{
    public class DBApplicationContext : DbContext
    {
        public DBApplicationContext(DbContextOptions<DBApplicationContext> option) : base(option)
        {

        }
        public DbSet<EmployeeModel> employees { get; set; }
    }
}


using DemoJWT.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoJWT.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        {
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        }
        public virtual DbSet<Employee>? Employees { get; set; }
        public virtual DbSet<User>? User { get; set; }       
    }
}

using Microsoft.EntityFrameworkCore;

namespace employee.api.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }

        public DbSet<EmployeeModel> EmployeeModels { get; set; }
    }
}

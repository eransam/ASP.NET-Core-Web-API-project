using Microsoft.EntityFrameworkCore;
using InsuranceApi_new.Models;

namespace InsuranceApi_new.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; } 
        public DbSet<InsurancePolicy> InsurancePolicies { get; set; }
    }
}

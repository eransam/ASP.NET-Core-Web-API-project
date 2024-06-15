using Microsoft.EntityFrameworkCore;
using InsuranceApi_new.Models; // Ensure this matches your namespace

namespace InsuranceApi_new.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<InsurancePolicy> InsurancePolicies { get; set; }

        // Add DbSet properties for other entities as needed
    }
}

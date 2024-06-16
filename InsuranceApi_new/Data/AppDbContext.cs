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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasMany(u => u.InsurancePolicies)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserID);
        }
    }
}

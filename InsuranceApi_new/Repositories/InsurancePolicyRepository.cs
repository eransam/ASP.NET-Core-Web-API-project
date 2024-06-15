using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InsuranceApi.Data;
using InsuranceApi.Models;
using InsuranceApi_new.Data;
using InsuranceApi_new.Models;
using YourNamespace.Repositories;

namespace InsuranceApi.Repositories
{
    public class InsurancePolicyRepository : IInsurancePolicyRepository
    {
        private readonly AppDbContext _context;

        public InsurancePolicyRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<InsurancePolicy>> GetPolicies()
        {
            return await _context.InsurancePolicies.ToListAsync();
        }

        public async Task<InsurancePolicy> GetPolicy(int id)
        {
            return await _context.InsurancePolicies.FindAsync(id);
        }

        public async Task<InsurancePolicy> AddPolicy(InsurancePolicy policy)
        {
            _context.InsurancePolicies.Add(policy);
            await _context.SaveChangesAsync();
            return policy;
        }

        public async Task<InsurancePolicy> UpdatePolicy(InsurancePolicy policy)
        {
            _context.Entry(policy).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return policy;
        }

        public async Task<InsurancePolicy> DeletePolicy(int id)
        {
            var policy = await _context.InsurancePolicies.FindAsync(id);
            if (policy != null)
            {
                _context.InsurancePolicies.Remove(policy);
                await _context.SaveChangesAsync();
            }
            return policy;
        }
    }
}

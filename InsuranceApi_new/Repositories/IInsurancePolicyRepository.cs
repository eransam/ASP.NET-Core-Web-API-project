using System.Collections.Generic;
using System.Threading.Tasks;
using InsuranceApi_new.Models;

namespace YourNamespace.Repositories // Replace with your actual namespace
{
    public interface IInsurancePolicyRepository
    {
        Task<IEnumerable<InsurancePolicy>> GetPolicies();
        Task<InsurancePolicy> GetPolicy(int id);
        Task<InsurancePolicy> AddPolicy(InsurancePolicy policy);
        Task<InsurancePolicy> UpdatePolicy(InsurancePolicy policy);
        Task<InsurancePolicy> DeletePolicy(int id);
    }
}

using InsuranceApi_new.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using InsuranceApi_new.Models;  // Use the actual namespace of your User model

namespace YourNamespace.Repositories  // Replace with your actual namespace
{
    public interface IInsurancePolicyRepository
    {
        Task<IEnumerable<InsurancePolicy>> GetAllPoliciesAsync();
        Task<InsurancePolicy> GetPolicyByIdAsync(int id);
        Task AddPolicyAsync(InsurancePolicy policy);
        Task UpdatePolicyAsync(InsurancePolicy policy);
        Task DeletePolicyAsync(int id);
    }
}

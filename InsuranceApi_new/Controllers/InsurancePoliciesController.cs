using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using InsuranceApi_new.Models;
using InsuranceApi_new.Repositories;
using InsuranceApi_new.Models;
using YourNamespace.Repositories;

namespace InsuranceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsurancePoliciesController : ControllerBase
    {
        private readonly IInsurancePolicyRepository _policyRepository;

        public InsurancePoliciesController(IInsurancePolicyRepository policyRepository)
        {
            _policyRepository = policyRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<InsurancePolicy>> GetPolicies()
        {
            return await _policyRepository.GetPolicies();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<InsurancePolicy>> GetPolicy(int id)
        {
            var policy = await _policyRepository.GetPolicy(id);
            if (policy == null)
            {
                return NotFound();
            }
            return policy;
        }

        [HttpPost]
        public async Task<ActionResult<InsurancePolicy>> PostPolicy(InsurancePolicy policy)
        {
            var newPolicy = await _policyRepository.AddPolicy(policy);
            return CreatedAtAction(nameof(GetPolicy), new { id = newPolicy.ID }, newPolicy);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPolicy(int id, InsurancePolicy policy)
        {
            if (id != policy.ID)
            {
                return BadRequest();
            }

            await _policyRepository.UpdatePolicy(policy);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePolicy(int id)
        {
            var policy = await _policyRepository.DeletePolicy(id);
            if (policy == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}

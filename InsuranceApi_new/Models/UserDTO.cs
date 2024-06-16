namespace InsuranceApi_new.Models
{
    public class UserDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<InsurancePolicyDTO> InsurancePolicies { get; set; } = new List<InsurancePolicyDTO>();
    }

    public class InsurancePolicyDTO
    {
        public int ID { get; set; }
        public string PolicyNumber { get; set; }
        public decimal InsuranceAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}

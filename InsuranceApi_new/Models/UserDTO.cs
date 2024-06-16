namespace InsuranceApi_new.Models
{
    public class UserDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<int> InsurancePolicyIds { get; set; } = new List<int>();
    }
}

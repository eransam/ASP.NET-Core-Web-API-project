﻿namespace InsuranceApi_new.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public ICollection<InsurancePolicy> InsurancePolicies { get; set; }
    }
}

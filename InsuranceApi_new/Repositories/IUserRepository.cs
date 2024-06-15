using System.Collections.Generic;
using System.Threading.Tasks;
using InsuranceApi_new.Models; // Use the correct namespace

namespace InsuranceApi_new.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
        Task<User> AddUser(User user);
        Task<User> UpdateUser(User user);
        Task<User> DeleteUser(int id);
    }
}

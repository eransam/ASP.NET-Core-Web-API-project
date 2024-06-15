using System.Collections.Generic;
using System.Threading.Tasks;
using InsuranceApi_new.Models; // Use the correct namespace

namespace InsuranceApi_new.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(int id);
        Task AddUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(int id);
    }
}

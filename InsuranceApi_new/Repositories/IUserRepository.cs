using System.Collections.Generic;
using System.Threading.Tasks;
using InsuranceApi_new.Models;

namespace InsuranceApi_new.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserDTO>> GetUsers();
        Task<UserDTO> GetUser(int id);
        Task<User> AddUser(User user);
        Task<User> UpdateUser(User user);
        Task<User> DeleteUser(int id);
    }
}

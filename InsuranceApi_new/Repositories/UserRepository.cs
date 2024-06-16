using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InsuranceApi_new.Data;
using InsuranceApi_new.Models;

namespace InsuranceApi_new.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UserDTO>> GetUsers()
        {
            var users = await _context.Users
                .Include(u => u.InsurancePolicies)
                .ToListAsync();

            var userDTOs = users.Select(u => new UserDTO
            {
                ID = u.ID,
                Name = u.Name,
                Email = u.Email,
                InsurancePolicies = u.InsurancePolicies.Select(p => new InsurancePolicyDTO
                {
                    ID = p.ID,
                    PolicyNumber = p.PolicyNumber,
                    InsuranceAmount = p.InsuranceAmount,
                    StartDate = p.StartDate,
                    EndDate = p.EndDate
                }).ToList()
            });

            return userDTOs;
        }

        public async Task<UserDTO> GetUser(int id)
        {
            var user = await _context.Users
                .Include(u => u.InsurancePolicies)
                .FirstOrDefaultAsync(u => u.ID == id);

            if (user == null)
            {
                return null;
            }

            return new UserDTO
            {
                ID = user.ID,
                Name = user.Name,
                Email = user.Email,
                InsurancePolicies = user.InsurancePolicies.Select(p => new InsurancePolicyDTO
                {
                    ID = p.ID,
                    PolicyNumber = p.PolicyNumber,
                    InsuranceAmount = p.InsuranceAmount,
                    StartDate = p.StartDate,
                    EndDate = p.EndDate
                }).ToList()
            };
        }

        public async Task<User> AddUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> UpdateUser(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<User> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
            return user;
        }
    }
}

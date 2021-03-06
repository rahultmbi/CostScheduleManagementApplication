using System.Threading.Tasks;
using CostManagementAPI.Models;

namespace CostManagementAPI.Data
{
    public interface IAuthRepository
    {
        Task<User> Login(string username, string password);
        Task<User> Register(User user, string password);
        Task<bool> UserExists(string username);
        string GenerateIsbn(string isbn);
    }
}
using Domain.Modles;
using System.Threading.Tasks;

namespace UserService.Repositories
{
    public interface IUserRepository
    {
        Task AddUserAsync(Users user);
        Task<Users> GetUserByUsernameAsync(string username);
    }
}

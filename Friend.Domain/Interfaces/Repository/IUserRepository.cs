using Friend.Domain.Entities;
using System.Threading.Tasks;

namespace Friend.Domain.Interfaces.Repository
{
    public interface IUserRepository
    {
        Task<int> Create(User user);

        Task<User> Login(User user);

        void Update(User user);

        Task<User> GetUserById(int userId);

        string GenerateToken(User user);
    }
}

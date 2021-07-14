using Friend.Domain.Entities;
using System.Threading.Tasks;

namespace Friend.Domain.Interfaces.Repository
{
    public interface IUserRepository
    {
        Task<int> Create(User user);
    }
}

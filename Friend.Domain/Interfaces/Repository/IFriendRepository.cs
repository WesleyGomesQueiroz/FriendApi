using Friend.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Friend.Domain.Interfaces.Repository
{
    public interface IFriendRepository
    {
        Task<int> Create(Friends friends);

        void Update(Friends friends);

        Task<Friends> GetFriendById(int friendId);

        List<Friends> GetAllFriends(int userId);
    }
}

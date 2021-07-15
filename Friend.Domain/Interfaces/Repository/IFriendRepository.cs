using Friend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friend.Domain.Interfaces.Repository
{
    public interface IFriendRepository
    {
        Task<int> Create(Friends friends);

        void Update(Friends friends);

        Task<Friends> GetFriendById(int friendId);

        Task<Friends> GetAllFriends(int userId);
    }
}

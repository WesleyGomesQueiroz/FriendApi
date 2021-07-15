using Friend.Domain.Entities;
using Friend.Domain.Interfaces.Repository;
using Friend.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friend.Domain.Services
{
    public class FriendService: IFriendService
    {
        private readonly IFriendRepository _friendRepository;

        public FriendService(IFriendRepository friendRepository)
        {
            _friendRepository = friendRepository;
        }

        public async Task<ActionResult<dynamic>> Create(Friends friends)
        {
            string message = "";
            bool status = false;

            var friendId = await _friendRepository.Create(friends);

            var friendList = _friendRepository.GetFriendById(friendId);

            if (friendList != null)
            {
                message = $"Amigo {friends.Name} criado com sucesso!";
                status = true;
            }

            return new
            {
                friendList,
                message,
                status
            };
        }

        public async Task<ActionResult<dynamic>> Update(Friends friends)
        {
            _friendRepository.Update(friends);

            var resFriend = _friendRepository.GetFriendById(friends.Id);

            return new { resFriend };
        }

        public async Task<ActionResult<dynamic>> GetFriendById(Friends friends)
        {
            var resFriend = _friendRepository.GetFriendById(friends.Id);

            return new { resFriend };
        }

        public async Task<ActionResult<dynamic>> GetAllFriends(Friends friends)
        {         
            var resFriend = _friendRepository.GetAllFriends(friends.IdUser);

            return new { resFriend };
        }

    }
}

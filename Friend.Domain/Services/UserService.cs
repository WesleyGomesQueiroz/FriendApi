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
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<ActionResult<dynamic>> Create(User user)
        {
            string message = "";
            bool status = false;
            var token = "";

            var userId = await _userRepository.Create(user);

            var userList = _userRepository.GetUserById(userId);

            if (userList != null)
            {
                message = $"Usuario {user.Name} criado com sucesso!";
                token = _userRepository.GenerateToken(user);
                status = true;
            }

            return new
            {
                userList,
                message,
                status,
                token
            };
        }

        public async Task<ActionResult<dynamic>> Update(User user)
        {
            _userRepository.Update(user);

            var resUser = _userRepository.GetUserById(user.Id);

            return new { resUser };
        }

        public async Task<ActionResult<dynamic>> Login(User user)
        {
            string message = "";
            bool status = false;
            var token = "";

            var resUser = await _userRepository.Login(user);

            if (resUser is null)
            {
                message = "Login ou senha invalidas!";
            }
            else
            {
                token = _userRepository.GenerateToken(resUser);
                status = true;
            }

            return new
            {
                resUser,
                message,
                status,
                token
            };
        }
    }
}

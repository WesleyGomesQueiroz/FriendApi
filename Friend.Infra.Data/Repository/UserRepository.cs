using Friend.Domain.Entities;
using Friend.Domain.Interfaces.Repository;
using Friend.Infra.Data.EntityFramework;
using Friend.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Friend.Infra.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        public async Task<int> Create(User user)
        {
            using var db = new ApplicationContext();

            var userData = new User
            {
                Name = user.Name,
                Email = user.Email,
                Document = user.Document,
                Password = Constants.EncryptSenha(user.Password),
                DTCreate = DateTime.Now,
                DTUpdate = null
            };

            db.Set<User>().Add(userData);

            db.SaveChanges();

            return userData.Id;
        }

        public async Task<User> Login(User user)
        {
            using var db = new ApplicationContext();

            return await db.Users.FirstOrDefaultAsync(
                x =>
                x.Email == user.Email &&
                x.Password == Constants.EncryptSenha(user.Password));
        }

        public void Update(User user)
        {
            using var db = new ApplicationContext();

            var userData = new User
            {
                Id = user.Id
            };

            var userDisconected = new
            {
                Name = user.Name,
                Email = user.Email,
                Document = user.Document,
                Password = Constants.EncryptSenha(user.Password),
                DTUpdate = DateTime.Now
            };

            db.Attach(userData);
            db.Entry(userData).CurrentValues.SetValues(userDisconected);

            db.SaveChanges();
        }

        public async Task<User> GetUserById(int userId)
        {
            using var db = new ApplicationContext();

            return await db.Users.FirstOrDefaultAsync(
                x =>
                x.Id == userId);
        }
    }
}

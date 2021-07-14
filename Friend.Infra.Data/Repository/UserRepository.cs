using Friend.Domain.Entities;
using Friend.Domain.Interfaces.Repository;
using Friend.Infra.Data.EntityFramework;
using Friend.Shared;
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
    }
}

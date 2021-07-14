using Friend.Domain.Entities;
using Friend.Domain.Interfaces.Repository;
using Friend.Infra.Data.EntityFramework;
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
                Password = user.Password,
                DTCreate = DateTime.Now,
                DTUpdate = null
            };

            db.Set<User>().Add(userData);

            db.SaveChanges();

            return userData.Id;
        }
    }
}

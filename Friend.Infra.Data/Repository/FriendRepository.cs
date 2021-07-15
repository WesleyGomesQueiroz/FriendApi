using Friend.Domain.Entities;
using Friend.Infra.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friend.Infra.Data.Repository
{
    public class FriendRepository
    {
        public async Task<int> Create(Friends friends)
        {
            using var db = new ApplicationContext();

            var friendData = new Friends
            {
                IdUser = friends.IdUser,
                Name = friends.Name,
                Email = friends.Email,
                DDD = friends.DDD,
                Phone = friends.Phone,
                Adress = friends.Adress,
                Status = true,
                DTCreate = DateTime.Now,
                DTUpdate = null
            };

            db.Set<Friends>().Add(friendData);

            db.SaveChanges();

            return friendData.Id;
        }
    }
}

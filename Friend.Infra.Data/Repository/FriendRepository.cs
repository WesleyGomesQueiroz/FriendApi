using Friend.Domain.Entities;
using Friend.Domain.Interfaces.Repository;
using Friend.Infra.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friend.Infra.Data.Repository
{
    public class FriendRepository: IFriendRepository
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

        public void Update(Friends friends)
        {
            using var db = new ApplicationContext();

            var friendsData = new Friends
            {
                Id = friends.Id
            };

            var userDisconected = new
            {
                Id = friends.Id,
                IdUser = friends.IdUser,
                Name = friends.Name,
                Email = friends.Email,
                DDD = friends.DDD,
                Phone = friends.Phone,
                Adress = friends.Adress,
                Status = friends.Status,
                DTUpdate = DateTime.Now
            };

            db.Attach(friendsData);
            db.Entry(friendsData).CurrentValues.SetValues(userDisconected);

            db.SaveChanges();
        }

        public async Task<Friends> GetFriendById(int friendId)
        {
            using var db = new ApplicationContext();

            return await db.Friends.FirstOrDefaultAsync(
                x =>
                x.Id == friendId);
        }

        public List<Friends> GetAllFriends(int userId)
        {
            using var db = new ApplicationContext();

            return db.Friends.Where(x => x.IdUser == userId).ToList();
        }
    }
}

using Friend.Domain.Entities;
using Friend.Infra.Data.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Friend.Tests
{
    [TestClass]
    public class FriendTest
    {
        private readonly FriendRepository _friendRepository = new FriendRepository();

        [TestMethod]
        public void Create()
        {
            var friend = new Friends
            {
                IdUser = 1,
                Name = "Alessandro Lima Cabral",
                Email = "alessandro@gmail.com",
                DDD = "11",
                Phone = "982940135",
                Adress = "Rua: Porto Amazonas N° 400 São Paulo - SP"
            };

            _friendRepository.Create(friend);
        }

        [TestMethod]
        public void Update()
        {
            var friend = new Friends
            {
                Id = 1,
                IdUser = 1,
                Name = "Alessandro Lima Cabral",
                Email = "alessandro@gmail.com",
                DDD = "11",
                Phone = "982940135",
                Adress = "Rua: Porto Amazonas N° 400 São Paulo - SP",
                Status = true
            };

            _friendRepository.Update(friend);
        }
    }
}

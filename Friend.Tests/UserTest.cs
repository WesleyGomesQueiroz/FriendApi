using Friend.Domain.Entities;
using Friend.Infra.Data.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Friend.Tests
{
    [TestClass]
    public class UserTest
    {
        private readonly UserRepository _userRepository = new UserRepository();

        [TestMethod]
        public void Create()
        {
            var user = new User
            {
                Name = "Wesley Gomes Queiroz",
                Email = "wesleygomesqueiroz@gmail.com",
                Document = "11111111111",
                Password = "wesley@123"
            };

            _userRepository.Create(user);
        }
        
        [TestMethod]
        public void Update()
        {
            var user = new User
            {
                Id = 1,
                Name = "Wesley Queiroz",
                Email = "wesleyqueiroz@gmail.com",
                Document = "22222222222",
                Password = "123"
            };

            _userRepository.Update(user);
        }
    }
}

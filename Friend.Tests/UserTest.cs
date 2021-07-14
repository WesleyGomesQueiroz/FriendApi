using Friend.Domain.Entities;
using Friend.Infra.Data.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Document = "41330497805",
                Password = "wesley@123"
            };

            _userRepository.Create(user);
        }
    }
}

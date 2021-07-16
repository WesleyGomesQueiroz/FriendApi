using Friend.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Friend.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<ActionResult<dynamic>> Login(User user);

        Task<ActionResult<dynamic>> Create(User user);

        Task<ActionResult<dynamic>> Update(User user);
    }
}

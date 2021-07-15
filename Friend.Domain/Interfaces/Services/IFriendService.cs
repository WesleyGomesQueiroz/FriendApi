using Friend.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friend.Domain.Interfaces.Services
{
    public interface IFriendService
    {
        Task<ActionResult<dynamic>> Create(Friends friends);

        Task<ActionResult<dynamic>> Update(Friends friends);

        Task<ActionResult<dynamic>> GetFriendById(Friends friends);

        Task<ActionResult<dynamic>> GetAllFriends(Friends friends);
    }
}

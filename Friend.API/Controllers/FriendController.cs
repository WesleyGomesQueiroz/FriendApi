using Friend.Domain.Entities;
using Friend.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcContrib.PortableAreas;
using System.Threading.Tasks;

namespace Friend.API.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class FriendController : Controller
    {
        private readonly IFriendService _friendService;

        public FriendController(IFriendService friendService)
        {
            _friendService = friendService;
        }

        [HttpPost]
        [Route("create")]
        [Authorize]
        public async Task<ActionResult<ICommandResult>> Create([FromBody] Friends friends)
        {
            return Ok(await _friendService.Create(friends));
        }

        [HttpPost]
        [Route("update")]
        [Authorize]
        public async Task<ActionResult<ICommandResult>> Update([FromBody] Friends friends)
        {
            return Ok(await _friendService.Update(friends));
        }
        
        [HttpPost]
        [Route("friend-by-id")]
        [Authorize]
        public async Task<ActionResult<ICommandResult>> GetFriendById([FromBody] Friends friends)
        {
            return Ok(await _friendService.GetFriendById(friends));
        }

        [HttpPost]
        [Route("get-all-friends")]
        [Authorize]
        public async Task<ActionResult<ICommandResult>> GetAllFriends([FromBody] Friends friends)
        {
            return Ok(await _friendService.GetAllFriends(friends));
        }


    }
}

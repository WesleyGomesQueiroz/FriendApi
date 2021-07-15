using Friend.Domain.Entities;
using Friend.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using MvcContrib.PortableAreas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friend.API.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<ICommandResult>> Login([FromBody] User user)
        {
            return Ok(await _userService.Login(user));
        }

        [HttpPost]
        [Route("create")]
        public async Task<ActionResult<ICommandResult>> Create([FromBody] User user)
        {
            return Ok(await _userService.Create(user));
        }

        [HttpPost]
        [Route("update")]
        public async Task<ActionResult<ICommandResult>> Update([FromBody] User user)
        {
            return Ok(await _userService.Update(user));
        }


    }
}

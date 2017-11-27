using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FlatsAndRooms.Services;
using FlatsAndRooms.ViewModels;
using System.Net;

namespace FlatsAndRooms.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        [HttpGet]
        public IEnumerable<UserToShowVM> Get()
        {
            UserService us = new UserService();
            return us.GetAllUsers();
        }
        [HttpPost]
        public IActionResult Post([FromBody]UserToShowVM user)
        {
            UserService us = new UserService();
            if (us.AddUser(user)) {
                return StatusCode((int)HttpStatusCode.OK);
            }
            else
            {
                return StatusCode((int)HttpStatusCode.NoContent);
            }
        }

    }
}
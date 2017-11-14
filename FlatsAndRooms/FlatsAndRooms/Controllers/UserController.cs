using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FlatsAndRooms.Services;
using FlatsAndRooms.ViewModels;

namespace FlatsAndRooms.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        [HttpGet]
        public IEnumerable<UserVM> Get()
        {
            UserService us = new UserService();
            return us.GetAllUsers();
        }
        
    }
}
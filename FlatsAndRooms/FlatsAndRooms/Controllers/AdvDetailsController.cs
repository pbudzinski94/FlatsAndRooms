using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlatsAndRooms.Services;
using FlatsAndRooms.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlatsAndRooms.Controllers
{
    [Produces("application/json")]
    [Route("api/AdvDetails")]
    public class AdvDetailsController : Controller
    {
        AdvDetailsService advDetailsService = new AdvDetailsService();
        [HttpGet("{id}")]
        public AdvDetails getAdvDetails(Guid id)
        {
            return advDetailsService.MapAdvDetails(id);
        }
    }
}
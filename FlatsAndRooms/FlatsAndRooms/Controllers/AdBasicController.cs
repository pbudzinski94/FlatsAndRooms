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
    [Route("api/AdBasic")]
    public class AdBasicController : Controller
    {
        AdBasicService adBasicService = new AdBasicService();
        [HttpGet("all")]
        public IEnumerable<AdBasic> getAllAdBasics()
        {
            return adBasicService.getAdBasics();
        }
    }
}
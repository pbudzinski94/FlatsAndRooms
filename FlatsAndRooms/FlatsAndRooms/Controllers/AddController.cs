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
    [Route("api/Add")]
    public class AddController : Controller
    {
        AdvertismentToAddService advertismentToAddService = new AdvertismentToAddService();
        [HttpPost("new")]
        public string AddNewAdvertisment([FromBody] AdvertismentToAdd advertismentToAdd)
        {
            advertismentToAddService.AddAdvertisment(advertismentToAdd);
            return "";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FlatsAndRooms.ViewModels;
using FlatsAndRooms.Services;
using FlatAndRooms.Models;

namespace FlatsAndRooms.Controllers
{
    [Produces("application/json")]
    [Route("api/ObjectToRent")]
    public class ObjectToRentController : Controller
    {
        
        [HttpGet("{id}")]
        public IEnumerable<ObjectToRentVM> GetByUserId(Guid id)
        {
            ObjectToRentService objectToRentService = new ObjectToRentService();
            return objectToRentService.GetObjectToRentFromUser(id);
        }
        [HttpGet]
        public IEnumerable<ObjectToRentVM> GetAll()
        {
            ObjectToRentService objectToRentService = new ObjectToRentService();
            return objectToRentService.GetAllObjectToRent();
        }
    }
}
using FlatAndRooms.Models;
using FlatsAndRooms.Repositories;
using FlatsAndRooms.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatsAndRooms.Services
{
    public class ObjectToRentService
    {
        private ObjectToRentRepository objectToRentRepository;
        private UserRepository userRepository;
        public ObjectToRentService()
        {
            objectToRentRepository = new ObjectToRentRepository();
            userRepository = new UserRepository();
        }
        public IEnumerable<ObjectToRentVM> GetObjectToRentFromUser(Guid ownerId)
        {
            
            IEnumerable<ObjectToRent> objectToRents = objectToRentRepository.Get();
            var otrVMs = from o in objectToRents where o.UserId == ownerId select new ObjectToRentVM() { AddedDate = o.AddedDate, ObjectToRentId = o.ObjectToRentId, Floor = o.Floor, OwnerNickName = userRepository.Get(ownerId).NickName };
            return otrVMs;
        }
        public IEnumerable<ObjectToRentVM> GetAllObjectToRent()
        {
            IEnumerable<ObjectToRent> objectToRents = objectToRentRepository.Get();
            var otrVMs = from o in objectToRents select new ObjectToRentVM() { AddedDate = o.AddedDate, ObjectToRentId = o.ObjectToRentId, Floor = o.Floor, OwnerNickName = userRepository.Get(o.UserId ?? default(Guid)).NickName };
            return otrVMs;
        }
        public void AddFewObjectsToRent(IEnumerable<ObjectToRent> objectToRents, IEnumerable<Guid> ids)
        {
            for (int i = 0; i < objectToRents.Count(); i++)
            {
                objectToRents.ElementAt(i).UserId = ids.ElementAt(i);
            }
            objectToRentRepository.Create(objectToRents);
        }

    }
}

using FlatAndRooms.Models;
using FlatAndRooms.Models.Enums;
using FlatsAndRooms.Repositories;
using FlatsAndRooms.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatsAndRooms.Services
{
    public class AdBasicService
    {
        ObjectToRentRepository objectToRentRepository = new ObjectToRentRepository();
        LocationRepository locationRepository = new LocationRepository();

        public List<AdBasic> getAdBasics()
        {
            IEnumerable<ObjectToRent> objectToRents = objectToRentRepository.Get();
            IEnumerable<Location> locations = locationRepository.Get();
            List<AdBasic> adBasics = new List<AdBasic>();
            foreach (var item in objectToRents)
            {
                adBasics.Add(MapAdBasic(item, locations.ToList().Find(x => x.LocationId == item.LocationId)));
            }
            adBasics.Sort((x, y) => y.AddDate.CompareTo(x.AddDate));
            adBasics.Reverse();
            return adBasics;
        }
        private AdBasic MapAdBasic(ObjectToRent objectToRent, Location location)
        {
            return new AdBasic()
            {
                AddDate = objectToRent.AddedDate,
                Id = objectToRent.ObjectToRentId,
                PeopleNumber = objectToRent.PeopleNumber,
                Prize = objectToRent.Prize,
                Type = objectToRent.Type,
                Title = objectToRent.PeopleNumber.ToString() + "-beds " + (objectToRent.Type == ObjectToRentType.Flat ? "Flat " : "Room ") + " in " + location.City + " " + location.Address
            };
        }
    }
}

using FlatAndRooms.Models;
using FlatsAndRooms.Repositories;
using FlatsAndRooms.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatsAndRooms.Services
{
    public class AdvertismentToAddService
    {
        LocationRepository locationRepository = new LocationRepository();
        EquipmentObjectToRentRepository equipmentObjectToRentRepository = new EquipmentObjectToRentRepository();
        EquipmentsRepository equipmentsRepository = new EquipmentsRepository();
        UserRepository userRepository = new UserRepository();
        ObjectToRentRepository objectToRentRepository = new ObjectToRentRepository();


        public bool AddAdvertisment(AdvertismentToAdd advertismentToAdd)
        {
            try
            {
                List<Equipment> newEq = getNewEquipmentFromAdvToAdd(advertismentToAdd);
                List<Equipment> oldEq = getOldEquipmentFromAdvToAdd(advertismentToAdd);
                List<EquipmentObjectToRent> currentEq = getEquipmentObjectToRentFromAdvToAdd(advertismentToAdd);
                Guid userId = advertismentToAdd.UserId;
                Location location = getLocationFromAdvToAdd(advertismentToAdd);
                ObjectToRent objectToRent = getObjectToRentFromAdvToAdd(advertismentToAdd);
                objectToRent.UserId = userId;
                objectToRent.Location = location;
                objectToRent.EquipmentObjectToRents = currentEq;
                for (int i = 0; i < advertismentToAdd.Equipments.Count(); i++)
                {
                    Equipment eq = oldEq.Find(x => x.EquipmentName == advertismentToAdd.Equipments.ElementAt(i).Name);
                    if(eq != null)
                    {
                        currentEq[i].EquipmentId = eq.EquipmentId;
                    }
                    else
                    {
                        currentEq[i].Equipment = newEq.Find(x => x.EquipmentName == advertismentToAdd.Equipments.ElementAt(i).Name);
                    }
                }
                objectToRentRepository.Create(objectToRent);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        private List<Equipment> getNewEquipmentFromAdvToAdd(AdvertismentToAdd advertismentToAdd)
        {
            List<Equipment> eqs = new List<Equipment>();
            List<Equipment> equipments = equipmentsRepository.Get().ToList();
            foreach (var item in advertismentToAdd.Equipments)
            {
                if(equipments.Find(x => x.EquipmentName.Equals(item.Name)) == null)
                {
                    eqs.Add(new Equipment() { EquipmentName = item.Name });
                }
            }
            return eqs;
        }
        private List<Equipment> getOldEquipmentFromAdvToAdd(AdvertismentToAdd advertismentToAdd)
        {
            List<Equipment> eqs = new List<Equipment>();
            List<Equipment> equipments = equipmentsRepository.Get().ToList();
            foreach (var item in equipments)
            {
                if (advertismentToAdd.Equipments.ToList().Find(x => x.Name.Equals(item.EquipmentName)) != null)
                {
                    eqs.Add(item);
                }
            }
            return eqs;
        }
        private List<EquipmentObjectToRent> getEquipmentObjectToRentFromAdvToAdd(AdvertismentToAdd advertismentToAdd)
        {
            List<EquipmentObjectToRent> eqs = new List<EquipmentObjectToRent>();
            foreach (var item in advertismentToAdd.Equipments)
            {
                eqs.Add(new EquipmentObjectToRent() { EquipmentDescription = item.Description });
            }
            return eqs;
        }
        private Location getLocationFromAdvToAdd(AdvertismentToAdd advertismentToAdd)
        {
            return new Location() { City = advertismentToAdd.City, Address = advertismentToAdd.Address };
        }
        private ObjectToRent getObjectToRentFromAdvToAdd(AdvertismentToAdd advertismentToAdd)
        {
            return new ObjectToRent() { AddedDate = DateTime.Now, Floor = advertismentToAdd.Floor, Prize = advertismentToAdd.Prize, PeopleNumber = advertismentToAdd.PeopleNumber, RoomsNumber = advertismentToAdd.RoomsNumber, Type = advertismentToAdd.Type };
        }
    }
}

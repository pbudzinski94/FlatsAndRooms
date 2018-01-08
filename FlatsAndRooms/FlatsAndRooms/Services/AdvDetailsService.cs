using FlatAndRooms.Models;
using FlatAndRooms.Models.Enums;
using FlatsAndRooms.Repositories;
using FlatsAndRooms.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatsAndRooms.Services
{
    public class AdvDetailsService
    {
        LocationRepository locationRepository = new LocationRepository();
        UserRepository userRepository = new UserRepository();
        ObjectToRentRepository objectToRentRepository = new ObjectToRentRepository();
        EquipmentObjectToRentRepository equipmentObjectToRentRepository = new EquipmentObjectToRentRepository();
        EquipmentsRepository equipmentsRepository = new EquipmentsRepository();
        ObjectToRentPreferencesRepository objectToRentPreferencesRepository = new ObjectToRentPreferencesRepository();

        public AdvDetails MapAdvDetails(Guid id)
        {
            ObjectToRent objectToRent = objectToRentRepository.Get(id);
            User user = userRepository.Get(objectToRent.UserId.Value);
            Location location = locationRepository.Get(objectToRent.LocationId.Value);
            List<EquipmentObjectToRent> equipments = equipmentObjectToRentRepository.Get().ToList().FindAll(x => x.ObjectToRentId == objectToRent.ObjectToRentId);
            AdvDetails advDetails = new AdvDetails() { Description = MakeDescription(objectToRent, location, equipments), AddDate = objectToRent.AddedDate, Address = location.City + " " + location.Address, email = user.EMail, Phone = user.PhoneNumber, Prize = objectToRent.Prize };
            return advDetails;
        }
        private string MakeDescription(ObjectToRent objectToRent, Location location, List<EquipmentObjectToRent> equipmentObjectToRent)
        {
            StringBuilder desc = new StringBuilder();
            desc.Append(objectToRent.PeopleNumber.ToString());
            desc.Append("-bed ");
            desc.Append(ObjectToRentTypeString(objectToRent.Type));
            desc.Append(" in ");
            desc.Append(location.City).Append(" on ").Append(location.Address).Append(".").Append(Environment.NewLine);
            if (equipmentObjectToRent.Count > 0)
            {
                desc.Append(ObjectToRentTypeCapitalString(objectToRent.Type)).Append(" contain equipments like: ").Append(Environment.NewLine);
                foreach (var item in MakeEquipmentList(equipmentObjectToRent))
                {
                    desc.Append("- ").Append(item.Name);
                    if(item.Description.Length > 0)
                    {
                        desc.Append(": ").Append(item.Description);
                    }
                    desc.Append(Environment.NewLine);
                }
            }
            return desc.ToString();
            
        }
        private string ObjectToRentTypeString(ObjectToRentType objectToRentType)
        {
            return objectToRentType == ObjectToRentType.Flat ? "flat" : "room";
        }
        private string ObjectToRentTypeCapitalString(ObjectToRentType objectToRentType)
        {
            return objectToRentType == ObjectToRentType.Flat ? "Flat" : "Foom";
        }
        private List<EquipmentVM> MakeEquipmentList(List<EquipmentObjectToRent> equipmentsObjectToRent)
        {
            List<EquipmentVM> eqs = new List<EquipmentVM>();
            List<Equipment> equipments = equipmentsRepository.Get().ToList();
            foreach (var item in equipmentsObjectToRent)
            {
                eqs.Add(new EquipmentVM() { Name = equipments.Find(x => x.EquipmentId == item.EquipmentId).EquipmentName, Description = item.EquipmentDescription });
            }
            return eqs;
        }
    }
}

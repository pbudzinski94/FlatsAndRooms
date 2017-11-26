using FlatsAndRooms.Preferences.ObjectToRentPreferences.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlatAndRooms.Models;
using Newtonsoft.Json;

namespace FlatsAndRooms.Preferences.ObjectToRentPreferences
{
    public class LocalizationPreference : IUserPreferenceMap
    {
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string Type { get { return "LocalizationPreference"; } }

        public float PreferedDistance { get; set; }

        public void MapFromUserPreference(UserPreference objectToRentPreference)
        {
            LocalizationPreference temp = JsonConvert.DeserializeObject<LocalizationPreference>(objectToRentPreference.PreferenceDescription);
            this.Latitude = temp.Latitude;
            this.Longitude = temp.Longitude;
            this.PreferedDistance = temp.PreferedDistance;
        }

        public UserPreference MapToUserPreference()
        {
            return new UserPreference { PreferenceDescription = JsonConvert.SerializeObject(this) };
        }
    }
}

using FlatsAndRooms.Preferences.ObjectToRentPreferences.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlatAndRooms.Models;
using Newtonsoft.Json;

namespace FlatsAndRooms.Preferences.ObjectToRentPreferences
{
    public class GenderPreferences : IObjectToRentMap
    {
        public string Type { get { return "GenderPreferences"; } }
        public Gender Gender { get; set; }

        public void MapFromUserPreference(ObjectToRentPreference objectToRentPreference)
        {
            GenderPreferences temp = JsonConvert.DeserializeObject<GenderPreferences>(objectToRentPreference.PreferenceDescription);
            this.Gender = temp.Gender;
        }

        public ObjectToRentPreference MapToUserPreference()
        {
            return new ObjectToRentPreference { PreferenceDescription = JsonConvert.SerializeObject(this) };
        }
    }
}

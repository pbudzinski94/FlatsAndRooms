using FlatAndRooms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatsAndRooms.Preferences.ObjectToRentPreferences.Abstract
{
    interface IUserPreferenceMap
    {
        string Type { get; }
        UserPreference MapToUserPreference();
        void MapFromUserPreference(UserPreference userPreferences);
    }
}

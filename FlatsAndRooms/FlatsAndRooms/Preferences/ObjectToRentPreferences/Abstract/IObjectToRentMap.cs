using FlatAndRooms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatsAndRooms.Preferences.ObjectToRentPreferences.Abstract
{
    interface IObjectToRentMap
    {
        string Type { get; }
        ObjectToRentPreference MapToUserPreference();
        void MapFromUserPreference(ObjectToRentPreference objectToRentPreference);
        bool IsPersonIsRight(User user);
    }
}

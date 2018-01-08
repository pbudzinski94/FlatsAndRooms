using FlatAndRooms.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatsAndRooms.ViewModels
{
    public class AdBasic
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public double Prize { get; set; }
        public ObjectToRentType Type { get; set; }
        public DateTime AddDate { get; set; }
        public int PeopleNumber { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatAndRooms.Models
{
    public class FlatAndRoomsContext : DbContext
    {
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentObjectToRent> EquipmentObjectToRents { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<ObjectToRent> ObjectToRents { get; set; }
        public DbSet<ObjectToRentPreference> ObjectToRentPreferences { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPreference> UserPreference { get; set; }

        public FlatAndRoomsContext(DbContextOptions<FlatAndRoomsContext> options) : base(options)
        {

        }
    }
}

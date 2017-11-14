using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatAndRooms.Models
{
    public class FlatAndRoomsContext : DbContext
    {
        private static FlatAndRoomsContext flatAndRoomsContext;
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentObjectToRent> EquipmentObjectToRents { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<ObjectToRent> ObjectToRents { get; set; }
        public DbSet<ObjectToRentPreference> ObjectToRentPreferences { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPreference> UserPreference { get; set; }

        public FlatAndRoomsContext(DbContextOptions<FlatAndRoomsContext> options) : base(options)
        {
            flatAndRoomsContext = this;
        }
        public FlatAndRoomsContext()
        {
            
        }
        public static FlatAndRoomsContext getThisContext()
        {
            return flatAndRoomsContext;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var connection = @"Server=(localdb)\mssqllocaldb;Database=FlatAndRooms;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connection);
        }
    }
}

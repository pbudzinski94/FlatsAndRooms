using FlatAndRooms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatsAndRooms.Repositories
{
    public class EquipmentsRepository : Repository<Equipment>
    {
       

        public override IEnumerable<Equipment> Get()
        {
            return dbContext.Equipments.ToList();
        }
        public override Equipment Get(Guid id)
        {
            try
            {
                return dbContext.Equipments.Where(x => x.EquipmentId == id).ToList()[0];
            }
            catch (Exception)
            {
                return null;
            }
        }
        public override bool Create(Equipment equipment)
        {
            try
            {
                dbContext.Equipments.Add(equipment);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public override bool Create(IEnumerable<Equipment> equipments)
        {
            try
            {
                dbContext.Equipments.AddRange(equipments);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public override bool Delete(IEnumerable<Equipment> equipments)
        {
            try
            {
                dbContext.Equipments.RemoveRange(equipments);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public override bool Delete(Equipment equipment)
        {
            try
            {
                dbContext.Equipments.Remove(equipment);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public override bool Delete(Guid id)
        {
            try
            {
                dbContext.Equipments.RemoveRange(dbContext.Equipments.Where(x => x.EquipmentId == id));
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public override bool Update(Guid id, Equipment item)
        {
            try
            {
                if (this.Delete(id))
                {
                    dbContext.Equipments.Add(item);
                    dbContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}

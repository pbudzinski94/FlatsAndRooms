using FlatAndRooms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatsAndRooms.Repositories
{
    public class EquipmentObjectToRentRepository : Repository<EquipmentObjectToRent>
    {
        

        public override bool Create(EquipmentObjectToRent item)
        {
            try
            {
                dbContext.EquipmentObjectToRents.Add(item);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override bool Create(IEnumerable<EquipmentObjectToRent> items)
        {
            try
            {
                dbContext.EquipmentObjectToRents.AddRange(items);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override bool Delete(IEnumerable<EquipmentObjectToRent> items)
        {
            try
            {
                dbContext.EquipmentObjectToRents.RemoveRange(items);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override bool Delete(EquipmentObjectToRent item)
        {
            try
            {
                dbContext.EquipmentObjectToRents.Remove(item);
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
                dbContext.EquipmentObjectToRents.RemoveRange(dbContext.EquipmentObjectToRents.Where(x => x.EquipmentObjectToRentId == id));
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override IEnumerable<EquipmentObjectToRent> Get()
        {
            return dbContext.EquipmentObjectToRents.ToList();
        }

        public override EquipmentObjectToRent Get(Guid id)
        {
            try
            {
                return dbContext.EquipmentObjectToRents.Where(x => x.EquipmentObjectToRentId == id).ToList()[0];
            }
            catch (Exception)
            {
                return null;
            }
        }

        public override bool Update(Guid id, EquipmentObjectToRent item)
        {
            try
            {
                if (this.Delete(id))
                {
                    dbContext.EquipmentObjectToRents.Add(item);
                    dbContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}

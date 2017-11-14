using FlatAndRooms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatsAndRooms.Repositories
{
    public abstract class Repository<T> : IRepository<T>
    {
        protected FlatAndRoomsContext dbContext;
        public Repository()
        {
            dbContext = new FlatAndRoomsContext();
        }
        public abstract bool Create(T item);
        public abstract bool Create(IEnumerable<T> items);
        public abstract bool Delete(IEnumerable<T> items);
        public abstract bool Delete(T item);
        public abstract bool Delete(Guid id);
        public abstract IEnumerable<T> Get();
        public abstract T Get(Guid id);
        public abstract bool Update(Guid id, T item);
    }
}

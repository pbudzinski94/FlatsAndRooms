using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlatsAndRooms.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> Get();
        T Get(Guid id);
        bool Create(T item);
        bool Create(IEnumerable<T> items);
        bool Delete(IEnumerable<T> items);
        bool Delete(T item);
        bool Delete(Guid id);
        bool Update(Guid id, T item);
    }
}

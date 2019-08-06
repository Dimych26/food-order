using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepository<T>: IDisposable where T : class
    {
        void Create(T item);

        IEnumerable<T> Get(Func<T, bool> predicate);
        T GetOne(Func<T, bool> predicate);
        IEnumerable<T> GetAll();
        void Remove(int id);
        void Update(T item);
    }
}

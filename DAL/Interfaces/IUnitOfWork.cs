using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Dish> Dishes { get; }
        IRepository<Menu> Menu { get; }
        IRepository<Order> Orders { get; }
        void Save();
        void Dispose();
    }
}

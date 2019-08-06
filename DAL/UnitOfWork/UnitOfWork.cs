using DAL.Context;
using DAL.Entities;
using DAL.Interfaces;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
   public class UnitOfWork: IUnitOfWork, IDisposable
    {
        private LabContext context;
        public UnitOfWork()
        {
           context = new LabContext();
        }

        private IRepository<Dish> dishes;
        public IRepository<Dish> Dishes
        {
            get
            {
                if (dishes == null)
                    dishes = new GenericRepository<Dish>(context);
                return dishes;
            }
        }

        private IRepository<Menu> menu;
        public IRepository<Menu> Menu
        {
            get
            {
                if (menu == null)
                    menu = new GenericRepository<Menu>(context);
                return menu;
            }
        }

        private IRepository<Order> order;
        public IRepository<Order> Orders
        {
            get
            {
                if (order == null)
                    order = new GenericRepository<Order>(context);
                return order;
            }
        }

       

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}

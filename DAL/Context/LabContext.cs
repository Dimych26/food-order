using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
   public class LabContext:DbContext
    {
        public LabContext():base("Lab3Context")
        {

        }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}

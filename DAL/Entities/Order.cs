using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class Order
    {
       
        public int Id { get; set; }
        public virtual List<Dish> Dishes { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Order()
        {
            Dishes = new List<Dish>();
        }
    }
}

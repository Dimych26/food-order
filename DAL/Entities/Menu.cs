using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Menu
    {
        public int Id { get; set; }
        public string Day { get; set; }
        public virtual List<Dish> Dishes { get; set; }
        public Menu()
        {
            Dishes = new List<Dish>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class ComplexDish
    {
        public int Id { get; set; }
        public DayOfWeek Day { get; set; }
        public virtual List<Dish> ListOfDish { get; set; }

        public ComplexDish()
        {
            ListOfDish = new List<Dish>();
        }
    }
}

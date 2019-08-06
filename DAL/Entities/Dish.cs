using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public enum TypeDish
    {
        FirstDish = 1,
        SecondDish,
        ThirdDish
    }
    public class Dish
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public int Price { get; set; }
        //public string Type { get; set; }
        //public List<DayOfWeek> DayOfWeeks { get; set; }
        //public int? ComplexDishId { get; set; }
        //public virtual ComplexDish ComplexDish { get; set; }
        //public Dish()
        //{
        //    DayOfWeeks = new List<DayOfWeek>();
        //}
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public virtual List<Menu> Menus { get; set; }
        public virtual List<Order> Orders { get; set; }
        public Dish()
        {
            Menus = new List<Menu>();
            Orders = new List<Order>();
        }

    }
}

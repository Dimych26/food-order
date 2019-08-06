using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ModelDTO
{
   
    public class DishDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public virtual List<OrderDTO> OrderDTOs { get; set; }
        public virtual List<MenuDTO> MenuDTOs { get; set; }
        public DishDTO()
        {
            OrderDTOs = new List<OrderDTO>();
            MenuDTOs = new List<MenuDTO>();
        }
    }
}

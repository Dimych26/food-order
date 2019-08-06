using System.Collections.Generic;

namespace BLL.ModelDTO
{
    public class OrderDTO
    {
        public int ID { get; set; }
        public virtual List<DishDTO> Dishes { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public OrderDTO()
        {
            Dishes = new List<DishDTO>();
        }
    }
}
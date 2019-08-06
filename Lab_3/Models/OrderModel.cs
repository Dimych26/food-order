using BLL.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_3.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual List<DishDTO> Dishes { get; set; }
        public OrderModel()
        {
            Dishes = new List<DishDTO>();
        }
    }
}
using BLL.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_3.Models
{
    public enum TypeDish
    {
        FirstDish = 1,
        SecondDish,
        ThirdDish
    }
    public class DishModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public virtual List<OrderModel> orderModel { get; set; }
        public virtual List<MenuModel> menuModel { get; set; }
        public DishModel()
        {
            orderModel = new List<OrderModel>();
            menuModel = new List<MenuModel>();
        }
    }
}
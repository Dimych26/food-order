using BLL.ModelDTO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_3.Models
{
    public class MenuModel
    {
        public int Id { get; set; }
        public string Day { get; set; }
        public virtual List<DishModel> DishModels { get; set; }
        public MenuModel()
        {
            DishModels = new List<DishModel>();
        }
    }
}
using BLL.ModelDTO;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IDishLogic
    {
        //List<Dish> GetSelectedDishes(List<DishDTO> list);
        //void ChangeDay();
        void AddDish(DishDTO dish);
        void DeleteDish(int id);
        void Update(DishDTO dish);
       // List<DishDTO> FindOnDay(string day);
        DishDTO GetDish(int id);
        IEnumerable<DishDTO> GetAll();
    }
}

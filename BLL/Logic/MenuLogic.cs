using AutoMapper;
using BLL.Infrastructure;
using BLL.Interfaces;
using BLL.ModelDTO;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Logic
{
    public class MenuLogic : IMenuLogic
    {
        IUnitOfWork uow;
        public MenuLogic(IUnitOfWork u)
        {
            uow = u;
        }
        public MenuLogic()
        {
            uow = LogicDependencyResolver.ResolveUoW();
        }
        IMapper DishMapper = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Menu, MenuDTO>();
            cfg.CreateMap<MenuDTO, Menu>();
            cfg.CreateMap<Dish, DishDTO>();
            cfg.CreateMap<DishDTO, Dish>();
        }).CreateMapper();

        public void Create(MenuDTO menu)
        {
            uow.Menu.Create(DishMapper.Map<MenuDTO,Menu>(menu));
        }

        public void Update(MenuDTO menu)
        {
            uow.Menu.Update(DishMapper.Map<MenuDTO, Menu>(menu));
        }

       

        public void Remove(int id)
        {
            uow.Menu.Remove(id);
        }

        public List<MenuDTO> GetAll()
        {
            return DishMapper.Map<IEnumerable<Menu>, List<MenuDTO>>(uow.Menu.GetAll());
        }

        public MenuDTO Get(int id)
        {
            return DishMapper.Map<Menu,MenuDTO>(uow.Menu.GetOne(menu=>menu.Id==id));
        }

        

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        //public ComplexDishDTO ComplexDinner(string day)
        //{
        //    //throw new NotImplementedException();
        //    Dish dish1 = uow.Dishes.GetOne(d => d.DayOfWeeks.Contains((DayOfWeek)Enum.Parse(typeof(DayOfWeek), day)) && d.Type == "FirstDish");
        //    //uow.Dishes.Update(dish1);
        //    Dish dish2 = uow.Dishes.GetOne(d => d.DayOfWeeks.Contains((DayOfWeek)Enum.Parse(typeof(DayOfWeek), day)) && d.Type == "SecondDish");
        //    //uow.Dishes.Update(dish2);
        //    Dish dish3 = uow.Dishes.GetOne(d => d.DayOfWeeks.Contains((DayOfWeek)Enum.Parse(typeof(DayOfWeek), day)) && d.Type == "ThirdDish");
        //    //uow.Dishes.Update(dish1);
        //    //uow.Save();
        //    uow.ComplexDishes.Create(new ComplexDish() { ListOfDish = new List<Dish> { dish1, dish2, dish3 } });
        //    var order = uow.ComplexDishes.GetOne(d => d.ListOfDish.Contains(dish1));
        //    return DishMapper.Map<ComplexDish, ComplexDishDTO>(order);
        //}

    }
}

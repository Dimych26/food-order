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
    public class DishLogic : IDishLogic
    {
        IMapper DishMapper = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Dish, DishDTO>();
            cfg.CreateMap<DishDTO, Dish>();
        }).CreateMapper();

        IUnitOfWork uow;
        public DishLogic(IUnitOfWork u)
        {
            uow = u;
        }
        public DishLogic()
        {
            uow = LogicDependencyResolver.ResolveUoW();
        }
        public void AddDish(DishDTO dish)
        {
            uow.Dishes.Create(DishMapper.Map<DishDTO, Dish>(dish));
        }

       

        public void DeleteDish(int id)
        {
            uow.Dishes.Remove(id);
        }

        

        public IEnumerable<DishDTO> GetAll()
        {
            return DishMapper.Map<IEnumerable<Dish>,IEnumerable<DishDTO>>(uow.Dishes.GetAll());
        }

        public DishDTO GetDish(int id)
        {
            return DishMapper.Map<Dish, DishDTO>(uow.Dishes.GetOne(dh=>dh.Id==id));
        }

       
        public void Update(DishDTO dish)
        {
            uow.Dishes.Update(DishMapper.Map<DishDTO, Dish>(dish));
        }
    }
}

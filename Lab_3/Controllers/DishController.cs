using AutoMapper;
using BLL.Interfaces;
using BLL.ModelDTO;
using Lab_3.Models;
using Lab_3.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lab_3.Controllers
{
    public class DishController : ApiController
    {
        IDishLogic dishLogic;
        // GET: api/Dish
       
        public DishController(IDishLogic logic)
        {
            
            dishLogic = logic;
            //dishLogic.ChangeDay();
        }
        public DishController()
        {
            dishLogic = UIDependencyResolver<IDishLogic>.ResolveDependency();
            //dishLogic.ChangeDay();
        }

        IMapper DishMapper = new MapperConfiguration(cfg =>
          {
              cfg.CreateMap<DishModel, DishDTO>();
              cfg.CreateMap<DishDTO, DishModel>();
          }).CreateMapper();
        public IEnumerable<DishModel> GetAllDish()
        {
            return DishMapper.Map<IEnumerable<DishDTO>, List<DishModel>>(dishLogic.GetAll());
        }

        //public IEnumerable<DishModel> GetOrder([FromBody]IEnumerable<DishModel> value)
        //{
        //    //return dishLogic.
        //}

        // GET: api/Dish/5
        public DishModel GetDish(int id)
        {
            return DishMapper.Map<DishDTO, DishModel>(dishLogic.GetDish(id));
        }

        // POST: api/Dish
        public void Post([FromBody]DishModel value)
        {
            dishLogic.AddDish(DishMapper.Map<DishModel, DishDTO>(value));
        }

        // PUT: api/Dish/5
        public void Put(int id, [FromBody]DishModel value)//передавай коллекцію dishmodel з view в якій будемо мінять complexdishid
        {
            value.Id = id;
            dishLogic.Update(DishMapper.Map<DishModel, DishDTO>(value));
        }

        // DELETE: api/Dish/5
        public void Delete(int id)
        {
            dishLogic.DeleteDish(id);
        }
    }
}

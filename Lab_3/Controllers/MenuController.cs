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
    public class MenuController : ApiController
    {
        IMenuLogic menuLogic;
        // GET: api/Dish
        IMapper MenuMapper = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<MenuModel, MenuDTO>();
            cfg.CreateMap<MenuDTO, MenuModel>();
        }).CreateMapper();
        public MenuController(IMenuLogic logic)
        {

            menuLogic = logic;

        }
        public MenuController()
        {
            menuLogic = UIDependencyResolver<IMenuLogic>.ResolveDependency();
            
        }
        // GET: api/ComplexDish
        public IEnumerable<MenuModel> Get()
        {
            return MenuMapper.Map<IEnumerable<MenuDTO>, List<MenuModel>>(menuLogic.GetAll());
        }

        // GET: api/ComplexDish/5
        public MenuDTO Get(int id)
        {
            // return MenuMapper.Map<MenuDTO, MenuModel>(menuLogic.Get(id));
            return menuLogic.Get(id);
        }

        // POST: api/ComplexDish
        public void Post([FromBody]MenuModel value)
        {
             menuLogic.Create(MenuMapper.Map<MenuModel, MenuDTO>((value)));
        }

        // PUT: api/ComplexDish/5
        public void Put(int id, [FromBody]MenuModel value)
        {
            value.Id = id;
            menuLogic.Update(MenuMapper.Map<MenuModel, MenuDTO>(value));
        }

        // DELETE: api/ComplexDish/5
        public void Delete(int id)
        {
            menuLogic.Remove(id);
        }
    }
}

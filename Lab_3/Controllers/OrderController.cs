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
    public class OrderController : ApiController
    {
        IOrderLogic orderLogic;
        // GET: api/Dish
        IMapper OrderMapper = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<OrderModel, OrderDTO>();
            cfg.CreateMap<OrderDTO, OrderModel>();
        }).CreateMapper();
        public OrderController(IOrderLogic logic)
        {

            orderLogic = logic;

        }
        public OrderController()
        {
            orderLogic = UIDependencyResolver<IOrderLogic>.ResolveDependency();

        }
        // GET: api/Order
        public IEnumerable<OrderModel> Get()
        {
            return OrderMapper.Map<IEnumerable<OrderDTO>, List<OrderModel>>(orderLogic.GetAll());
        }

        // GET: api/Order/5
        public OrderModel Get(int id)
        {
            return OrderMapper.Map<OrderDTO, OrderModel>(orderLogic.Get(id));
        }

        // POST: api/Order
        public void Post([FromBody]OrderModel value)
        {
            orderLogic.Create(OrderMapper.Map<OrderModel, OrderDTO>(value));
        }

        // PUT: api/Order/5
        public void Put(int id, [FromBody]OrderModel value)
        {
            value.Id = id;
            orderLogic.Update(OrderMapper.Map<OrderModel, OrderDTO>(value));
        }

        // DELETE: api/Order/5
        public void Delete(int id)
        {
            orderLogic.Remove(id);
        }
    }
}

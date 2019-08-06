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
    public class OrderLogic:IOrderLogic
    {
        IMapper OrderMapper = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Order, OrderDTO>();
            cfg.CreateMap<OrderDTO, Order>();
        }).CreateMapper();

        IUnitOfWork uow;
        public OrderLogic(IUnitOfWork u)
        {
            uow = u;
        }
        public OrderLogic()
        {
            uow = LogicDependencyResolver.ResolveUoW();
        }

        public void Create(OrderDTO order)
        {
            uow.Orders.Create(OrderMapper.Map<OrderDTO, Order>(order));
        }

        public void Update(OrderDTO order)
        {
            uow.Orders.Update(OrderMapper.Map<OrderDTO, Order>(order));
        }

        public void Remove(int id)
        {
            uow.Orders.Remove(id);
        }

        public IEnumerable<OrderDTO> GetAll()
        {
            return OrderMapper.Map<IEnumerable<Order>, List<OrderDTO>>(uow.Orders.GetAll());
        }

        public OrderDTO Get(int id)
        {
            return OrderMapper.Map<Order,OrderDTO>(uow.Orders.GetOne(or => or.Id == id));
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

using BLL.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IOrderLogic
    {
        void Create(OrderDTO order);
        //void Edit(OrderDTO order);
        //void Edit(OrderDTO order, DishDTO dish);
        //void Edit(OrderDTO order, int ind);
        void Update(OrderDTO order);
        void Remove(int id);
        IEnumerable<OrderDTO> GetAll();
        OrderDTO Get(int id);
        void Dispose();
    }
}

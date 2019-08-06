using BLL.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IMenuLogic
    {

        void Create(MenuDTO menu);
        //void Edit(MenuDTO menu, DishDTO dish);
        //void Edit(MenuDTO menu, int ind);
        void Update(MenuDTO menu);
        void Remove(int id);
        List<MenuDTO> GetAll();
        MenuDTO Get(int id);
       // MenuDTO Find(string day);
        void Dispose();
    }
}

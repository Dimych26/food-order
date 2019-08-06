using BLL.Interfaces;
using BLL.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_3.Util
{
    public static class UIDependencyResolver<T>
    {
        public static dynamic ResolveDependency()
        {
            if (typeof(T) == typeof(IDishLogic))
                return new DishLogic();
          
            else if (typeof(T) == typeof(IMenuLogic))
                return new MenuLogic();
            else if(typeof(T) == typeof(IOrderLogic))
                return new OrderLogic();


            else return null;
        }
    }
}
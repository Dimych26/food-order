using BLL.Interfaces;
using BLL.Logic;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_3.Util
{
    public class Binder:NinjectModule
    {
        public override void Load()
        {
            Bind<IDishLogic>().To<DishLogic>();
            

        }
    }
}
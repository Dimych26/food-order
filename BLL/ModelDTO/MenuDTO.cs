using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ModelDTO
{
   public class MenuDTO
    {
        public int Id { get; set; }
        public string Day { get; set; }
        public virtual List<DishDTO> DishDTOs { get; set; }
        public MenuDTO()
        {
            DishDTOs = new List<DishDTO>();
        }

    }
}

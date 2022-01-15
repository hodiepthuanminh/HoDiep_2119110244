using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.DTO
{
    public class FoodCategoryDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<FoodDTO> food { get; set; }
    }
}

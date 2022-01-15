
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.DTO
{
    public class FoodDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public FoodCategoryDTO category { get; set; }
        public string categoryname { get { return category.name; } }
        public float price { get; set; }
        public List<MenuDTO> mn { get; set; }
        public List<BillInfoDTO> bi { get; set; }
    }
}

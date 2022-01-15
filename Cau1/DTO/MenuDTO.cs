using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.DTO
{
    public class MenuDTO
    {
        public FoodDTO food { get;set; }
        public string foodname { get { return food.name; } }
        public BillInfoDTO bi { get; set; }
        public int count { get { return bi.count; } }
        public float price { get { return food.price; } }
        public float totalprice { get; set; }
        public RoomDTO ph { get; set; }
        public int idphong { get { return ph.id; } }
    }
}

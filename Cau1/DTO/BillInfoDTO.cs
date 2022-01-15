using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.DTO
{
    public class BillInfoDTO
    {
        public int id { get; set; }
        public BillDTO b { get; set; }
        public int idbill { get { return b.id; } }
        public FoodDTO f { get; set; }
        public int idfood { get { return f.id; } }
        public int count { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.DTO
{
    public class RoomDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public List<MenuDTO> mn { get; set; }
        public List<BillDTO> b { get; set; }
    }
}

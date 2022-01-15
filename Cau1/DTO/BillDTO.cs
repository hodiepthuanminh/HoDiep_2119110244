using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.DTO
{
    public class BillDTO
    {
         public int id { get; set; }
         public DateTime? datechekin { get; set; }
         public DateTime? datechekout { get; set; }
         public RoomDTO roon { get; set; }
         public int idphong { get { return roon.id; } }
         public int status { get; set; }
        public List<MenuDTO> mn { get; set; }
        public List<BillInfoDTO> bi { get; set; }
    }
}

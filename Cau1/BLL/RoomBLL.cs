using Cau1.DAO;
using Cau1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.BLL
{
    public class RoomBLL
    {
        RoomDAO dao = new RoomDAO();
        public List<RoomDTO> LoadRoom()
        {
            List<RoomDTO> lstRoom = dao.LoadRoom();
            return lstRoom;
        }
        public void GetRoomByID (RoomDTO room)
        {
            dao.GetRoomByID(room);
        }
    }
}

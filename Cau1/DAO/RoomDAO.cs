using Cau1.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.DAO
{
    public class RoomDAO : DBConnection
    {
        public List<RoomDTO> LoadRoom()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Get_ListPhong", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<RoomDTO> lstRoom = new List<RoomDTO>();
            while (reader.Read())
            {
                RoomDTO r = new RoomDTO();
                r.id = int.Parse(reader["id"].ToString());
                r.name = reader["name"].ToString();
                r.status = reader["status"].ToString();
                lstRoom.Add(r);
            }
            conn.Close();
            return lstRoom;
        }
        public void GetRoomByID(RoomDTO room)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("exec GetRoomByID @id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", room.id));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public RoomDTO GetRoom(int id)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select*from Phong where id=" + id.ToString(), conn);
            SqlDataReader reader = cmd.ExecuteReader();
            RoomDTO room = new RoomDTO();
            if (reader.HasRows && reader.Read())
            {
                room.id = int.Parse(reader["id"].ToString());
                room.name = reader["name"].ToString();
                room.status = reader["status"].ToString();
            }
            conn.Close();
            return room;
        }
    }
}

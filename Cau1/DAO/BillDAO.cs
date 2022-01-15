using Cau1.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.DAO
{
    public class BillDAO:DBConnection
    {
        public List<BillDTO> ReadListBill()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select*from Bill", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<BillDTO> lstBill = new List<BillDTO>();
            RoomDAO room = new RoomDAO();
            while (reader.Read())
            {
                BillDTO b = new BillDTO();
                b.id = int.Parse(reader["id"].ToString());
                b.datechekin = DateTime.Parse(reader["datechekin"].ToString());
                b.datechekout = DateTime.Parse(reader["datecheckout"].ToString());
                b.roon = room.GetRoom(int.Parse(reader["idphong"].ToString()));
                b.status = int.Parse(reader["status"].ToString());
            }
            conn.Close();
            return lstBill;

        }
        public BillDTO ReadBill(int id)
        {

            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select*from Bill where id=" + id.ToString(), conn);
            SqlDataReader reader = cmd.ExecuteReader();
            BillDTO bill = new BillDTO();
            RoomDAO room = new RoomDAO();
            if (reader.HasRows && reader.Read())
            {
                
                bill.id = int.Parse(reader["id"].ToString());
                bill.datechekin = DateTime.Parse(reader["datechekin"].ToString());
                bill.datechekout = DateTime.Parse(reader["datecheckout"].ToString());
                bill.roon = room.GetRoom(int.Parse(reader["idphong"].ToString()));
                bill.status = int.Parse(reader["status"].ToString());
            }
            conn.Close();
            return bill;
        }
    }
}

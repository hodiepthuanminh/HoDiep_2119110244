using Cau1.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.DAO
{
    public class BillInfoDAO:DBConnection
    {
        public List<BillInfoDTO> GetListBillInfo(BillInfoDTO billInfo)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("exec GetListBillIfo @idbill", conn);
            cmd.Parameters.Add(new SqlParameter("@idbill", billInfo.idbill));
            cmd.ExecuteNonQuery();
            
            List<BillInfoDTO> lstbillifo= new List<BillInfoDTO>();
            foreach(BillInfoDTO item in lstbillifo)
            {
                lstbillifo.Add(item);
            }
            return lstbillifo;
        }
        public BillInfoDTO ReadBillIfo(int id)
        {

            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select*from BillInfo where id=" + id.ToString(), conn);
            SqlDataReader reader = cmd.ExecuteReader();
            BillInfoDTO bi = new BillInfoDTO();
            
            FoodDAO food = new FoodDAO();
            BillDAO bill = new BillDAO();
            if (reader.HasRows && reader.Read())
            {
                bi.id = int.Parse(reader["id"].ToString());
                bi.b = bill.ReadBill(int.Parse(reader["idbill"].ToString()));
                bi.f = food.ReadFoodid(int.Parse(reader["idfood"].ToString()));
                bi.count = int.Parse(reader["count"].ToString());
            }
            conn.Close();
            return bi;
        }
    }
}

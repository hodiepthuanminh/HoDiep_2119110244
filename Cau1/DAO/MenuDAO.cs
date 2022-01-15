using Cau1.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.DAO
{
    public class MenuDAO:DBConnection
    {
        public List<MenuDTO> GetListMenu(int id)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("exec Get_Menu @idphong", conn);
            cmd.Parameters.Add(new SqlParameter("@iphong",id));
            SqlDataReader reader = cmd.ExecuteReader();
            List<MenuDTO> lstMenu = new List<MenuDTO>();
            FoodDAO food = new FoodDAO();
            RoomDAO rom = new RoomDAO();
            BillInfoDAO billifo = new BillInfoDAO();
            while (reader.Read())
            {
                MenuDTO menu = new MenuDTO();

                
                menu.bi = billifo.ReadBillIfo(int.Parse(reader["count"].ToString()));
                menu.food = food.ReadFoodid(int.Parse(reader["price"].ToString()));
                menu.totalprice = float.Parse(reader["thanhtien"].ToString());
                lstMenu.Add(menu);
            }
            conn.Close();
            return lstMenu;
        }
    }
}

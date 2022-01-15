using Cau1.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.DAO
{
    public class FoodCategoryDAO:DBConnection
    {
        public List<FoodCategoryDTO> ReadCategoryFood()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select*from FoodCategory", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<FoodCategoryDTO> lstCate = new List<FoodCategoryDTO>();
            while (reader.Read())
            {
                FoodCategoryDTO ct = new FoodCategoryDTO();
                ct.id = int.Parse(reader["id"].ToString());
                ct.name = reader["name"].ToString();
                lstCate.Add(ct);
            }
            conn.Close();
            return lstCate;

        }
        public FoodCategoryDTO ReadCate(int id)
        {

            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select*from FoodCategory where id="+id.ToString(), conn);
            SqlDataReader reader = cmd.ExecuteReader();
            FoodCategoryDTO cate = new FoodCategoryDTO();
            if(reader.HasRows && reader.Read())
            {
                cate.id = int.Parse(reader["id"].ToString());
                cate.name = reader["name"].ToString();
            }
            conn.Close();
            return cate;
        }
    }
}

using Cau1.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.DAO
{
    public class FoodDAO:DBConnection
    {
        public List<FoodDTO> ReadFood()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select*from Food", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<FoodDTO> lstFood = new List<FoodDTO>();
            FoodCategoryDAO cate = new FoodCategoryDAO();
            while (reader.Read())
            {
                FoodDTO food = new FoodDTO();
                food.id = int.Parse(reader["id"].ToString());
                food.name = reader["name"].ToString();
                food.category = cate.ReadCate(int.Parse(reader["idcategory"].ToString()));
                food.price = float.Parse(reader["price"].ToString());
                lstFood.Add(food);
            }
            conn.Close();
            return lstFood;
        }
        public void Add_Food(FoodDTO food)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("exec Add_Food @id, @name, @idcategory, @price", conn);
            cmd.Parameters.Add(new SqlParameter("@id", food.id));
            cmd.Parameters.Add(new SqlParameter("@name",food.name));
            cmd.Parameters.Add(new SqlParameter("@idcategory",food.category.id));
            cmd.Parameters.Add(new SqlParameter("@price",food.price));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Delete_Food(FoodDTO food)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("exec Delete_Food @id", conn);
            cmd.Parameters.Add(new SqlParameter("@id", food.id));          
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Edit_Food(FoodDTO food)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("exec Edit_Food @id, @name, @idcategory, @price", conn);
            cmd.Parameters.Add(new SqlParameter("@id", food.id));
            cmd.Parameters.Add(new SqlParameter("@name", food.name));
            cmd.Parameters.Add(new SqlParameter("@idcategory", food.category.id));
            cmd.Parameters.Add(new SqlParameter("@price", food.price));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public FoodDTO ReadFoodid(int id)
        {

            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select*from Food where id=" + id.ToString(), conn);
            SqlDataReader reader = cmd.ExecuteReader();
            FoodDTO food = new FoodDTO();
            FoodCategoryDAO cate = new FoodCategoryDAO();
            if (reader.HasRows && reader.Read())
            {
                food.id = int.Parse(reader["id"].ToString());
                food.name = reader["name"].ToString();
                food.category = cate.ReadCate(int.Parse(reader["idcategory"].ToString()));
                food.price = float.Parse(reader["price"].ToString());
            }
            conn.Close();
            return food;
        }
    }
}

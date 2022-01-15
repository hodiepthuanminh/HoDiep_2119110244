using Cau1.DAO;
using Cau1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.BLL
{
    public class FoodBLL
    {
        FoodDAO dao = new FoodDAO();
        public List<FoodDTO> ReadFood()
        {
            List<FoodDTO> lstFood = dao.ReadFood();
            return lstFood;
        }
        public void Add_Food(FoodDTO food)
        {
            dao.Add_Food(food);
        }
        public void Delete_Food(FoodDTO food)
        {
            dao.Delete_Food(food);
        }
        public void Edit_Food(FoodDTO food)
        {
            dao.Edit_Food(food);
        }
    }
}

using Cau1.DAO;
using Cau1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.BLL
{
    
    public class FoodCategoryBLL
    {
        FoodCategoryDAO dao = new FoodCategoryDAO();
        public List<FoodCategoryDTO> ReadCategoryFood()
        {
            List<FoodCategoryDTO> lstCate = dao.ReadCategoryFood();
            return lstCate;
        }
    }
}

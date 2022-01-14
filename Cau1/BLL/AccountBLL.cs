using Cau1.DAO;
using Cau1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.BLL
{
    class AccountBLL
    {
        AccountDAO dao = new AccountDAO();
        public List<AccountDTO> ReadAccount()
        {
            List<AccountDTO> lstAC = dao.ReadAccount();
            return lstAC;
        }
        public void Add_Account(AccountDTO ac)
        {
            dao.Add_Account(ac);
        }
        public void Delete_Account(AccountDTO ac)
        {
            dao.Delete_Account(ac);
        }
        public void Edit_Account(AccountDTO ac)
        {
            dao.Edit_Account(ac);
        }
    }
}

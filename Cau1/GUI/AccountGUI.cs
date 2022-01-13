using Cau1.BLL;
using Cau1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cau1.GUI
{
    public partial class AccountGUI : Form
    {
        AccountBLL acBLL = new AccountBLL();
        public AccountGUI()
        {
            InitializeComponent();
        }


        private void AccountGUI_Load(object sender, EventArgs e)
        {
            lstv_Account.Items.Clear();
            List<AccountDTO> lstAC = acBLL.ReadAccount();
            foreach (AccountDTO item in lstAC)
            {
                ListViewItem lstItem = new ListViewItem(item.username);
                lstItem.SubItems.Add(item.password);
                lstItem.SubItems.Add(item.displayname);
                lstItem.SubItems.Add(item.type);
                lstv_Account.Items.Add(lstItem);
            }
        }

        private void lstv_Account_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstv_Account.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lstv_Account.SelectedItems[0];
                string tendn = lvi.SubItems[0].Text;
                string tenht = lvi.SubItems[1].Text;
                string mk = lvi.SubItems[2].Text;
                string cv = lvi.SubItems[3].Text;
                txt_Username.Text = tendn;
                txt_DisplayName.Text = tenht;
                txt_Password.Text = mk;
                txt_Type.Text = cv;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AccountDTO ac = new AccountDTO();
            ac.username = txt_Username.Text;
            ac.displayname = txt_DisplayName.Text;
            ac.password = txt_Password.Text;
            ac.type = txt_Type.Text;
            acBLL.Add_Account(ac);
            ListViewItem lvi = new ListViewItem(ac.username);
            lvi.SubItems.Add(ac.displayname);
            lvi.SubItems.Add(ac.password);
            lvi.SubItems.Add(ac.type);
            lstv_Account.Items.Add(lvi);
        }
    }
}

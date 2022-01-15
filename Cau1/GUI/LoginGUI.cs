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
    public partial class LoginGUI : Form
    {
        AccountDTO ac = new AccountDTO();
        AccountBLL acBLL = new AccountBLL();
        public LoginGUI()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            ac.username = txt_UserName.Text;
            ac.password = txt_PassWord.Text;
            string getuser = acBLL.Login(ac);
            switch (getuser)
            {
                case "no_username":
                    MessageBox.Show("Tài khoản không được để trống");
                    return;
                case "no_password":
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;
                case "Sai thông tin đăng nhập!":
                    MessageBox.Show("Sai thông tin đăng nhập!");
                    return;
            }
            ManageGUI f = new ManageGUI();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

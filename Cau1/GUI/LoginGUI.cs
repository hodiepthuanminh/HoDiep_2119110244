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
        public LoginGUI()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            AccountGUI f = new AccountGUI();
            if(txt_UserName.Text=="bichhue" && txt_PassWord.Text == "123456")
            {
                f.Show();
            }
        }
    }
}

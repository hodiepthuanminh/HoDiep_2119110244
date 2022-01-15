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
    

    public partial class ManageGUI : Form
    {
        RoomBLL roomBLL = new RoomBLL();
        
        public ManageGUI()
        {
            InitializeComponent();
            LoadRoom();
        }
        void LoadRoom()
        {
            List<RoomDTO> lstRoom = roomBLL.LoadRoom();
            foreach(RoomDTO item in lstRoom)
            {
                Button btn = new Button() { Width = 80, Height = 80 };
                btn.Text = item.name + Environment.NewLine + item.status;
                btn.Click += Btn_Click;
                btn.Tag = item;
                switch (item.status)
                {
                    case "Trống":
                        btn.BackColor = Color.White;
                        break;
                    case "Có người":
                        btn.BackColor = Color.Aqua;
                        break;
                }
                flp_Room.Controls.Add(btn);

            }
        }

        void ShowBil(int id)
        {

        }
        private void Btn_Click(object sender, EventArgs e)
        {
            RoomDTO room = new RoomDTO();
            int roomID = room.id;
            ShowBil(roomID);
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountGUI f = new AccountGUI();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminGUI f = new AdminGUI();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}

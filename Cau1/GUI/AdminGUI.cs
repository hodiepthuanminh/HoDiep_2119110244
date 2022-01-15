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
    public partial class AdminGUI : Form
    {
        FoodBLL fBll = new FoodBLL();
        FoodCategoryBLL cateBLL = new FoodCategoryBLL();
        RoomBLL roomBLL = new RoomBLL();
        public AdminGUI()
        {
            InitializeComponent();
            LoadRoom();
        }
        void LoadRoom()
        {
            List<RoomDTO> lstRoom = roomBLL.LoadRoom();
            foreach (RoomDTO item in lstRoom)
            {
                Button btn = new Button() { Width = 80, Height = 80 };
                btn.Text = item.name + Environment.NewLine + item.status;
                btn.Click += Btn_Click;
                btn.Tag = item.name;
                
                switch (item.status)
                {
                    case "Trống":
                        btn.BackColor = Color.White;
                        break;
                    case "Có người":
                        btn.BackColor = Color.Aqua;
                        break;
                }
                flp_RoomAdmin.Controls.Add(btn);

            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            RoomDTO room = new RoomDTO();
            roomBLL.GetRoomByID(room);
            txt_IDRoom.Text = room.id.ToString();
            txt_NameRoom.Text = room.name;
        }

        private void AdminGUI_Load(object sender, EventArgs e)
        {
            List<FoodDTO> lstFood = fBll.ReadFood();
            foreach(FoodDTO item in lstFood)
            {
                dtgv_Food.Rows.Add(item.id, item.name, item.categoryname, item.price);

            }
            List<FoodCategoryDTO> lstCate = cateBLL.ReadCategoryFood();
            foreach(FoodCategoryDTO cate in lstCate)
            {
                cb_Category.Items.Add(cate);
            }
            cb_Category.DisplayMember = "name";
        }

        int idx;
        private void dtgv_Food_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;
            DataGridViewRow row = dtgv_Food.Rows[idx];
            if (row.Cells[0].Value != null)
            {
                txt_IDFood.Text = row.Cells[0].Value.ToString();
                txt_NameFood.Text = row.Cells[1].Value.ToString();
                cb_Category.Text = row.Cells[2].Value.ToString();
                txt_Price.Text = row.Cells[3].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FoodDTO food = new FoodDTO();
            food.id = int.Parse(txt_IDFood.Text);
            food.name = txt_NameFood.Text;
            food.category = (FoodCategoryDTO)cb_Category.SelectedItem;
            food.price = float.Parse(txt_Price.Text);
            fBll.Add_Food(food);
            dtgv_Food.Rows.Add(food.id, food.name, food.category.name, food.price);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn có chắc muốn xóa " + txt_NameFood.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                DataGridViewRow row = dtgv_Food.Rows[idx];
                if (row.Cells[0].Value != null)
                {
                    FoodDTO food = new FoodDTO();
                    food.id = int.Parse(txt_IDFood.Text);
                    fBll.Delete_Food(food);
                    dtgv_Food.Rows.RemoveAt(idx);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FoodDTO food = new FoodDTO();
            food.id = int.Parse(txt_IDFood.Text);
            food.name = txt_NameFood.Text;
            food.category = (FoodCategoryDTO)cb_Category.SelectedItem;
            food.price = float.Parse(txt_Price.Text);
            fBll.Edit_Food(food);

            DataGridViewRow row = dtgv_Food.CurrentRow;
            row.Cells[0].Value = food.id;
            row.Cells[1].Value = food.name;
            row.Cells[2].Value = food.category.name;
            row.Cells[3].Value = food.price;
        }
    }
}

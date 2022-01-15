
namespace Cau1.GUI
{
    partial class AdminGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tc_Admin = new System.Windows.Forms.TabControl();
            this.tp_Room = new System.Windows.Forms.TabPage();
            this.tp_Food = new System.Windows.Forms.TabPage();
            this.dtgv_Food = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ffffff = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_IDFood = new System.Windows.Forms.TextBox();
            this.txt_NameFood = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flp_RoomAdmin = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_IDRoom = new System.Windows.Forms.TextBox();
            this.txt_NameRoom = new System.Windows.Forms.TextBox();
            this.cb_StatusRoom = new System.Windows.Forms.ComboBox();
            this.tc_Admin.SuspendLayout();
            this.tp_Room.SuspendLayout();
            this.tp_Food.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Food)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_Admin
            // 
            this.tc_Admin.Controls.Add(this.tp_Room);
            this.tc_Admin.Controls.Add(this.tp_Food);
            this.tc_Admin.Location = new System.Drawing.Point(13, 13);
            this.tc_Admin.Name = "tc_Admin";
            this.tc_Admin.SelectedIndex = 0;
            this.tc_Admin.Size = new System.Drawing.Size(1029, 453);
            this.tc_Admin.TabIndex = 0;
            // 
            // tp_Room
            // 
            this.tp_Room.Controls.Add(this.groupBox3);
            this.tp_Room.Controls.Add(this.groupBox2);
            this.tp_Room.Location = new System.Drawing.Point(4, 25);
            this.tp_Room.Name = "tp_Room";
            this.tp_Room.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Room.Size = new System.Drawing.Size(1021, 424);
            this.tp_Room.TabIndex = 0;
            this.tp_Room.Text = "Phòng";
            this.tp_Room.UseVisualStyleBackColor = true;
            // 
            // tp_Food
            // 
            this.tp_Food.Controls.Add(this.button3);
            this.tp_Food.Controls.Add(this.button2);
            this.tp_Food.Controls.Add(this.button1);
            this.tp_Food.Controls.Add(this.groupBox1);
            this.tp_Food.Controls.Add(this.dtgv_Food);
            this.tp_Food.Location = new System.Drawing.Point(4, 25);
            this.tp_Food.Name = "tp_Food";
            this.tp_Food.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Food.Size = new System.Drawing.Size(1021, 424);
            this.tp_Food.TabIndex = 1;
            this.tp_Food.Text = "Thức ăn";
            this.tp_Food.UseVisualStyleBackColor = true;
            // 
            // dtgv_Food
            // 
            this.dtgv_Food.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Food.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgv_Food.Location = new System.Drawing.Point(7, 7);
            this.dtgv_Food.Name = "dtgv_Food";
            this.dtgv_Food.RowHeadersWidth = 51;
            this.dtgv_Food.RowTemplate.Height = 24;
            this.dtgv_Food.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_Food.Size = new System.Drawing.Size(647, 411);
            this.dtgv_Food.TabIndex = 0;
            this.dtgv_Food.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_Food_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name";
            this.Column2.HeaderText = "Tên ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "categoryname";
            this.Column3.HeaderText = "Loại";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Category);
            this.groupBox1.Controls.Add(this.txt_Price);
            this.groupBox1.Controls.Add(this.txt_NameFood);
            this.groupBox1.Controls.Add(this.txt_IDFood);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ffffff);
            this.groupBox1.Location = new System.Drawing.Point(660, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // ffffff
            // 
            this.ffffff.AutoSize = true;
            this.ffffff.Location = new System.Drawing.Point(6, 42);
            this.ffffff.Name = "ffffff";
            this.ffffff.Size = new System.Drawing.Size(21, 17);
            this.ffffff.TabIndex = 0;
            this.ffffff.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá";
            // 
            // txt_IDFood
            // 
            this.txt_IDFood.Location = new System.Drawing.Point(65, 42);
            this.txt_IDFood.Name = "txt_IDFood";
            this.txt_IDFood.Size = new System.Drawing.Size(271, 22);
            this.txt_IDFood.TabIndex = 1;
            // 
            // txt_NameFood
            // 
            this.txt_NameFood.Location = new System.Drawing.Point(65, 72);
            this.txt_NameFood.Name = "txt_NameFood";
            this.txt_NameFood.Size = new System.Drawing.Size(271, 22);
            this.txt_NameFood.TabIndex = 1;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(65, 132);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(271, 22);
            this.txt_Price.TabIndex = 1;
            // 
            // cb_Category
            // 
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(65, 102);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(271, 24);
            this.cb_Category.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(927, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(846, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(765, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "Thêm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flp_RoomAdmin);
            this.groupBox2.Location = new System.Drawing.Point(7, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 411);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phòng";
            // 
            // flp_RoomAdmin
            // 
            this.flp_RoomAdmin.Location = new System.Drawing.Point(7, 22);
            this.flp_RoomAdmin.Name = "flp_RoomAdmin";
            this.flp_RoomAdmin.Size = new System.Drawing.Size(516, 389);
            this.flp_RoomAdmin.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_StatusRoom);
            this.groupBox3.Controls.Add(this.txt_NameRoom);
            this.groupBox3.Controls.Add(this.txt_IDRoom);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(542, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(473, 168);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tình trạng";
            // 
            // txt_IDRoom
            // 
            this.txt_IDRoom.Location = new System.Drawing.Point(107, 31);
            this.txt_IDRoom.Name = "txt_IDRoom";
            this.txt_IDRoom.Size = new System.Drawing.Size(163, 22);
            this.txt_IDRoom.TabIndex = 1;
            // 
            // txt_NameRoom
            // 
            this.txt_NameRoom.Location = new System.Drawing.Point(107, 59);
            this.txt_NameRoom.Name = "txt_NameRoom";
            this.txt_NameRoom.Size = new System.Drawing.Size(163, 22);
            this.txt_NameRoom.TabIndex = 1;
            // 
            // cb_StatusRoom
            // 
            this.cb_StatusRoom.FormattingEnabled = true;
            this.cb_StatusRoom.Location = new System.Drawing.Point(107, 88);
            this.cb_StatusRoom.Name = "cb_StatusRoom";
            this.cb_StatusRoom.Size = new System.Drawing.Size(163, 24);
            this.cb_StatusRoom.TabIndex = 2;
            // 
            // AdminGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 478);
            this.Controls.Add(this.tc_Admin);
            this.Name = "AdminGUI";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminGUI_Load);
            this.tc_Admin.ResumeLayout(false);
            this.tp_Room.ResumeLayout(false);
            this.tp_Food.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Food)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_Admin;
        private System.Windows.Forms.TabPage tp_Room;
        private System.Windows.Forms.TabPage tp_Food;
        private System.Windows.Forms.DataGridView dtgv_Food;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_NameFood;
        private System.Windows.Forms.TextBox txt_IDFood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ffffff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cb_StatusRoom;
        private System.Windows.Forms.TextBox txt_NameRoom;
        private System.Windows.Forms.TextBox txt_IDRoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flp_RoomAdmin;
    }
}
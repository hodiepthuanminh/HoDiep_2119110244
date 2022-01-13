
namespace Cau1.GUI
{
    partial class AccountGUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstv_Account = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_DisplayName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstv_Account);
            this.groupBox1.Location = new System.Drawing.Point(42, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 389);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý";
            // 
            // lstv_Account
            // 
            this.lstv_Account.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstv_Account.FullRowSelect = true;
            this.lstv_Account.HideSelection = false;
            this.lstv_Account.Location = new System.Drawing.Point(7, 21);
            this.lstv_Account.Name = "lstv_Account";
            this.lstv_Account.Size = new System.Drawing.Size(442, 361);
            this.lstv_Account.TabIndex = 0;
            this.lstv_Account.UseCompatibleStateImageBehavior = false;
            this.lstv_Account.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên đăng nhập";
            this.columnHeader1.Width = 153;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mật khẩu";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên Hiển thị";
            this.columnHeader3.Width = 137;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(395, 441);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(96, 37);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(293, 441);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(96, 37);
            this.btn_Edit.TabIndex = 1;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(191, 441);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(96, 37);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(89, 441);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(96, 37);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên đăng nhập :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên hiển thị :";
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(644, 91);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(170, 22);
            this.txt_Username.TabIndex = 3;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(644, 123);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(170, 22);
            this.txt_Password.TabIndex = 3;
            // 
            // txt_DisplayName
            // 
            this.txt_DisplayName.Location = new System.Drawing.Point(644, 154);
            this.txt_DisplayName.Name = "txt_DisplayName";
            this.txt_DisplayName.Size = new System.Drawing.Size(170, 22);
            this.txt_DisplayName.TabIndex = 3;
            // 
            // AccountGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 530);
            this.Controls.Add(this.txt_DisplayName);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.groupBox1);
            this.Name = "AccountGUI";
            this.Text = "AccountGUI";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstv_Account;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_DisplayName;
    }
}
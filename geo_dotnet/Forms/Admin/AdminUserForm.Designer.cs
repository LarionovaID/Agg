namespace geo_dotnet.Forms.Admin
{
	partial class AdminUserForm
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
			this.btn_Add = new System.Windows.Forms.Button();
			this.dgv_Users = new System.Windows.Forms.DataGridView();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_Edit = new System.Windows.Forms.Button();
			this.btn_Save = new System.Windows.Forms.Button();
			this.tb_Password = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tb_Login = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_Fio = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_Id = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btn_Refresh = new System.Windows.Forms.Button();
			this.tb_Search = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btn_Clear = new System.Windows.Forms.Button();
			this.adminsPanel1 = new geo_dotnet.Controls.Admin.AdminsPanel();
			this.cb_Role = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_Add
			// 
			this.btn_Add.Location = new System.Drawing.Point(572, 443);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(83, 30);
			this.btn_Add.TabIndex = 6;
			this.btn_Add.Text = "Добавить";
			this.btn_Add.UseVisualStyleBackColor = true;
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
			// 
			// dgv_Users
			// 
			this.dgv_Users.AllowUserToAddRows = false;
			this.dgv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Users.Location = new System.Drawing.Point(12, 127);
			this.dgv_Users.Name = "dgv_Users";
			this.dgv_Users.Size = new System.Drawing.Size(643, 310);
			this.dgv_Users.TabIndex = 7;
			this.dgv_Users.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Users_CellClick);
			this.dgv_Users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Users_CellContentClick);
			// 
			// btn_Delete
			// 
			this.btn_Delete.Location = new System.Drawing.Point(572, 489);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(83, 30);
			this.btn_Delete.TabIndex = 8;
			this.btn_Delete.Text = "Удалить";
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// btn_Edit
			// 
			this.btn_Edit.Location = new System.Drawing.Point(572, 525);
			this.btn_Edit.Name = "btn_Edit";
			this.btn_Edit.Size = new System.Drawing.Size(83, 30);
			this.btn_Edit.TabIndex = 9;
			this.btn_Edit.Text = "Изменить";
			this.btn_Edit.UseVisualStyleBackColor = true;
			this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(572, 561);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(83, 30);
			this.btn_Save.TabIndex = 10;
			this.btn_Save.Text = "Сохранить";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// tb_Password
			// 
			this.tb_Password.Location = new System.Drawing.Point(235, 525);
			this.tb_Password.Name = "tb_Password";
			this.tb_Password.Size = new System.Drawing.Size(154, 20);
			this.tb_Password.TabIndex = 21;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(235, 509);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 13);
			this.label5.TabIndex = 20;
			this.label5.Text = "Пароль";
			// 
			// tb_Login
			// 
			this.tb_Login.Location = new System.Drawing.Point(66, 525);
			this.tb_Login.Name = "tb_Login";
			this.tb_Login.Size = new System.Drawing.Size(163, 20);
			this.tb_Login.TabIndex = 19;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(66, 509);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 18;
			this.label4.Text = "Логин";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(395, 509);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "Роль";
			// 
			// tb_Fio
			// 
			this.tb_Fio.Location = new System.Drawing.Point(18, 571);
			this.tb_Fio.Name = "tb_Fio";
			this.tb_Fio.Size = new System.Drawing.Size(371, 20);
			this.tb_Fio.TabIndex = 15;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 555);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "Фио";
			// 
			// tb_Id
			// 
			this.tb_Id.Location = new System.Drawing.Point(18, 525);
			this.tb_Id.Name = "tb_Id";
			this.tb_Id.Size = new System.Drawing.Size(32, 20);
			this.tb_Id.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 509);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Id";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(31, 461);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(234, 25);
			this.label7.TabIndex = 24;
			this.label7.Text = "Управление записями";
			// 
			// btn_Refresh
			// 
			this.btn_Refresh.Location = new System.Drawing.Point(12, 91);
			this.btn_Refresh.Name = "btn_Refresh";
			this.btn_Refresh.Size = new System.Drawing.Size(83, 30);
			this.btn_Refresh.TabIndex = 26;
			this.btn_Refresh.Text = "Обновить";
			this.btn_Refresh.UseVisualStyleBackColor = true;
			this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
			// 
			// tb_Search
			// 
			this.tb_Search.Location = new System.Drawing.Point(537, 97);
			this.tb_Search.Name = "tb_Search";
			this.tb_Search.Size = new System.Drawing.Size(118, 20);
			this.tb_Search.TabIndex = 27;
			this.tb_Search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(495, 101);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(39, 13);
			this.label6.TabIndex = 28;
			this.label6.Text = "Поиск";
			// 
			// btn_Clear
			// 
			this.btn_Clear.Location = new System.Drawing.Point(395, 561);
			this.btn_Clear.Name = "btn_Clear";
			this.btn_Clear.Size = new System.Drawing.Size(139, 30);
			this.btn_Clear.TabIndex = 29;
			this.btn_Clear.Text = "Очистить";
			this.btn_Clear.UseVisualStyleBackColor = true;
			this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
			// 
			// adminsPanel1
			// 
			this.adminsPanel1.BackColor = System.Drawing.Color.DarkSlateGray;
			this.adminsPanel1.ForeColor = System.Drawing.SystemColors.Control;
			this.adminsPanel1.Location = new System.Drawing.Point(-5, 1);
			this.adminsPanel1.Name = "adminsPanel1";
			this.adminsPanel1.Size = new System.Drawing.Size(676, 72);
			this.adminsPanel1.TabIndex = 25;
			// 
			// cb_Role
			// 
			this.cb_Role.FormattingEnabled = true;
			this.cb_Role.Location = new System.Drawing.Point(395, 524);
			this.cb_Role.Name = "cb_Role";
			this.cb_Role.Size = new System.Drawing.Size(139, 21);
			this.cb_Role.TabIndex = 30;
			// 
			// AdminUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(669, 610);
			this.Controls.Add(this.cb_Role);
			this.Controls.Add(this.btn_Clear);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tb_Search);
			this.Controls.Add(this.btn_Refresh);
			this.Controls.Add(this.adminsPanel1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.tb_Password);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tb_Login);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tb_Fio);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tb_Id);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.btn_Edit);
			this.Controls.Add(this.btn_Delete);
			this.Controls.Add(this.dgv_Users);
			this.Controls.Add(this.btn_Add);
			this.Name = "AdminUserForm";
			this.Text = "AdminUserForm";
			this.Load += new System.EventHandler(this.AdminUserForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Controls.AdminPanel adminPanel1;
		private System.Windows.Forms.Button btn_Add;
		private System.Windows.Forms.DataGridView dgv_Users;
		private System.Windows.Forms.Button btn_Delete;
		private System.Windows.Forms.Button btn_Edit;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.TextBox tb_Password;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tb_Login;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_Fio;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_Id;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
		private Controls.Admin.AdminsPanel adminsPanel1;
		private System.Windows.Forms.Button btn_Refresh;
		private System.Windows.Forms.TextBox tb_Search;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btn_Clear;
		private System.Windows.Forms.ComboBox cb_Role;
	}
}
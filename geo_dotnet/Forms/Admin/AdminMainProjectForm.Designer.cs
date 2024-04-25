namespace geo_dotnet.Forms.Admin
{
	partial class AdminMainProjectForm
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
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tb_DateEnd = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tb_DateStart = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_Description = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_Id = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_Save = new System.Windows.Forms.Button();
			this.btn_Edit = new System.Windows.Forms.Button();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.dgv_Projects = new System.Windows.Forms.DataGridView();
			this.btn_Add = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.btn_Refresh = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.tb_Search = new System.Windows.Forms.TextBox();
			this.cb_Worker = new System.Windows.Forms.ComboBox();
			this.cb_Customer = new System.Windows.Forms.ComboBox();
			this.adminsPanel1 = new geo_dotnet.Controls.Admin.AdminsPanel();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Projects)).BeginInit();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(719, 99);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(234, 25);
			this.label7.TabIndex = 43;
			this.label7.Text = "Управление записями";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(851, 193);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 13);
			this.label6.TabIndex = 41;
			this.label6.Text = "Заказчик";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// tb_DateEnd
			// 
			this.tb_DateEnd.Location = new System.Drawing.Point(899, 163);
			this.tb_DateEnd.Name = "tb_DateEnd";
			this.tb_DateEnd.Size = new System.Drawing.Size(139, 20);
			this.tb_DateEnd.TabIndex = 40;
			this.tb_DateEnd.TextChanged += new System.EventHandler(this.tb_DateEnd_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(899, 147);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 13);
			this.label5.TabIndex = 39;
			this.label5.Text = "Дата окончания";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// tb_DateStart
			// 
			this.tb_DateStart.Location = new System.Drawing.Point(754, 163);
			this.tb_DateStart.Name = "tb_DateStart";
			this.tb_DateStart.Size = new System.Drawing.Size(139, 20);
			this.tb_DateStart.TabIndex = 38;
			this.tb_DateStart.TextChanged += new System.EventHandler(this.tb_DateStart_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(754, 147);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 13);
			this.label4.TabIndex = 37;
			this.label4.Text = "Дата начала";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(706, 193);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 35;
			this.label3.Text = "Работник";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// tb_Description
			// 
			this.tb_Description.Location = new System.Drawing.Point(706, 258);
			this.tb_Description.Multiline = true;
			this.tb_Description.Name = "tb_Description";
			this.tb_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tb_Description.Size = new System.Drawing.Size(350, 261);
			this.tb_Description.TabIndex = 34;
			this.tb_Description.TextChanged += new System.EventHandler(this.tb_Description_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(706, 242);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 33;
			this.label2.Text = "Описание";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// tb_Id
			// 
			this.tb_Id.Location = new System.Drawing.Point(706, 163);
			this.tb_Id.Name = "tb_Id";
			this.tb_Id.Size = new System.Drawing.Size(32, 20);
			this.tb_Id.TabIndex = 32;
			this.tb_Id.TextChanged += new System.EventHandler(this.tb_Id_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(706, 147);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 13);
			this.label1.TabIndex = 31;
			this.label1.Text = "Id";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(884, 525);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(83, 30);
			this.btn_Save.TabIndex = 30;
			this.btn_Save.Text = "Сохранить";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// btn_Edit
			// 
			this.btn_Edit.Location = new System.Drawing.Point(795, 525);
			this.btn_Edit.Name = "btn_Edit";
			this.btn_Edit.Size = new System.Drawing.Size(83, 30);
			this.btn_Edit.TabIndex = 29;
			this.btn_Edit.Text = "Изменить";
			this.btn_Edit.UseVisualStyleBackColor = true;
			this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
			// 
			// btn_Delete
			// 
			this.btn_Delete.Location = new System.Drawing.Point(706, 525);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(83, 30);
			this.btn_Delete.TabIndex = 28;
			this.btn_Delete.Text = "Удалить";
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// dgv_Projects
			// 
			this.dgv_Projects.AllowUserToAddRows = false;
			this.dgv_Projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Projects.Location = new System.Drawing.Point(16, 131);
			this.dgv_Projects.Name = "dgv_Projects";
			this.dgv_Projects.Size = new System.Drawing.Size(652, 468);
			this.dgv_Projects.TabIndex = 27;
			this.dgv_Projects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Projects_CellClick);
			this.dgv_Projects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Projects_CellContentClick);
			// 
			// btn_Add
			// 
			this.btn_Add.Location = new System.Drawing.Point(973, 525);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(83, 30);
			this.btn_Add.TabIndex = 26;
			this.btn_Add.Text = "Добавить";
			this.btn_Add.UseVisualStyleBackColor = true;
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(706, 569);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(172, 30);
			this.button4.TabIndex = 45;
			this.button4.Text = "Детали";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// btn_Refresh
			// 
			this.btn_Refresh.Location = new System.Drawing.Point(16, 94);
			this.btn_Refresh.Name = "btn_Refresh";
			this.btn_Refresh.Size = new System.Drawing.Size(83, 30);
			this.btn_Refresh.TabIndex = 46;
			this.btn_Refresh.Text = "Обновить";
			this.btn_Refresh.UseVisualStyleBackColor = true;
			this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(508, 104);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(39, 13);
			this.label8.TabIndex = 48;
			this.label8.Text = "Поиск";
			this.label8.Click += new System.EventHandler(this.label8_Click);
			// 
			// tb_Search
			// 
			this.tb_Search.Location = new System.Drawing.Point(550, 100);
			this.tb_Search.Name = "tb_Search";
			this.tb_Search.Size = new System.Drawing.Size(118, 20);
			this.tb_Search.TabIndex = 47;
			this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
			// 
			// cb_Worker
			// 
			this.cb_Worker.FormattingEnabled = true;
			this.cb_Worker.Location = new System.Drawing.Point(709, 207);
			this.cb_Worker.Name = "cb_Worker";
			this.cb_Worker.Size = new System.Drawing.Size(121, 21);
			this.cb_Worker.TabIndex = 49;
			this.cb_Worker.SelectedIndexChanged += new System.EventHandler(this.cb_Worker_SelectedIndexChanged);
			// 
			// cb_Customer
			// 
			this.cb_Customer.FormattingEnabled = true;
			this.cb_Customer.Location = new System.Drawing.Point(854, 207);
			this.cb_Customer.Name = "cb_Customer";
			this.cb_Customer.Size = new System.Drawing.Size(121, 21);
			this.cb_Customer.TabIndex = 50;
			this.cb_Customer.SelectedIndexChanged += new System.EventHandler(this.cb_Customer_SelectedIndexChanged);
			// 
			// adminsPanel1
			// 
			this.adminsPanel1.BackColor = System.Drawing.Color.DarkSlateGray;
			this.adminsPanel1.ForeColor = System.Drawing.SystemColors.Control;
			this.adminsPanel1.Location = new System.Drawing.Point(-5, 0);
			this.adminsPanel1.Name = "adminsPanel1";
			this.adminsPanel1.Size = new System.Drawing.Size(1089, 72);
			this.adminsPanel1.TabIndex = 44;
			// 
			// AdminMainProjectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1080, 614);
			this.Controls.Add(this.cb_Customer);
			this.Controls.Add(this.cb_Worker);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.tb_Search);
			this.Controls.Add(this.btn_Refresh);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.adminsPanel1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tb_DateEnd);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tb_DateStart);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tb_Description);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tb_Id);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.btn_Edit);
			this.Controls.Add(this.btn_Delete);
			this.Controls.Add(this.dgv_Projects);
			this.Controls.Add(this.btn_Add);
			this.Name = "AdminMainProjectForm";
			this.Text = "AdminMainForm";
			this.Load += new System.EventHandler(this.AdminMainProjectForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Projects)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tb_DateEnd;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tb_DateStart;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_Description;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_Id;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.Button btn_Edit;
		private System.Windows.Forms.Button btn_Delete;
		private System.Windows.Forms.DataGridView dgv_Projects;
		private System.Windows.Forms.Button btn_Add;
		private Controls.Admin.AdminsPanel adminsPanel1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button btn_Refresh;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tb_Search;
		private System.Windows.Forms.ComboBox cb_Worker;
		private System.Windows.Forms.ComboBox cb_Customer;
	}
}
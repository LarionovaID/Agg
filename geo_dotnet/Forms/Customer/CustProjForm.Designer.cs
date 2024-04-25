namespace geo_dotnet.Forms.Customer
{
	partial class CustProjForm
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
			this.cb_Customer = new System.Windows.Forms.ComboBox();
			this.cb_Worker = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tb_Search = new System.Windows.Forms.TextBox();
			this.btn_Refresh = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
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
			this.dgv_Projects = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Projects)).BeginInit();
			this.SuspendLayout();
			// 
			// cb_Customer
			// 
			this.cb_Customer.FormattingEnabled = true;
			this.cb_Customer.Location = new System.Drawing.Point(850, 133);
			this.cb_Customer.Name = "cb_Customer";
			this.cb_Customer.Size = new System.Drawing.Size(121, 21);
			this.cb_Customer.TabIndex = 72;
			// 
			// cb_Worker
			// 
			this.cb_Worker.FormattingEnabled = true;
			this.cb_Worker.Location = new System.Drawing.Point(705, 133);
			this.cb_Worker.Name = "cb_Worker";
			this.cb_Worker.Size = new System.Drawing.Size(121, 21);
			this.cb_Worker.TabIndex = 71;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(504, 30);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(39, 13);
			this.label8.TabIndex = 70;
			this.label8.Text = "Поиск";
			// 
			// tb_Search
			// 
			this.tb_Search.Location = new System.Drawing.Point(546, 26);
			this.tb_Search.Name = "tb_Search";
			this.tb_Search.Size = new System.Drawing.Size(118, 20);
			this.tb_Search.TabIndex = 69;
			// 
			// btn_Refresh
			// 
			this.btn_Refresh.Location = new System.Drawing.Point(12, 20);
			this.btn_Refresh.Name = "btn_Refresh";
			this.btn_Refresh.Size = new System.Drawing.Size(83, 30);
			this.btn_Refresh.TabIndex = 68;
			this.btn_Refresh.Text = "Обновить";
			this.btn_Refresh.UseVisualStyleBackColor = true;
			this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(702, 495);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(172, 30);
			this.button4.TabIndex = 67;
			this.button4.Text = "Детали";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(700, 21);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(334, 25);
			this.label7.TabIndex = 66;
			this.label7.Text = "Сведения о проектах заказчика";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(847, 119);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 13);
			this.label6.TabIndex = 65;
			this.label6.Text = "Заказчик";
			// 
			// tb_DateEnd
			// 
			this.tb_DateEnd.Location = new System.Drawing.Point(895, 89);
			this.tb_DateEnd.Name = "tb_DateEnd";
			this.tb_DateEnd.Size = new System.Drawing.Size(139, 20);
			this.tb_DateEnd.TabIndex = 64;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(895, 73);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 13);
			this.label5.TabIndex = 63;
			this.label5.Text = "Дата окончания";
			// 
			// tb_DateStart
			// 
			this.tb_DateStart.Location = new System.Drawing.Point(750, 89);
			this.tb_DateStart.Name = "tb_DateStart";
			this.tb_DateStart.Size = new System.Drawing.Size(139, 20);
			this.tb_DateStart.TabIndex = 62;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(750, 73);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 13);
			this.label4.TabIndex = 61;
			this.label4.Text = "Дата начала";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(702, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 60;
			this.label3.Text = "Работник";
			// 
			// tb_Description
			// 
			this.tb_Description.Location = new System.Drawing.Point(702, 184);
			this.tb_Description.Multiline = true;
			this.tb_Description.Name = "tb_Description";
			this.tb_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tb_Description.Size = new System.Drawing.Size(350, 292);
			this.tb_Description.TabIndex = 59;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(702, 168);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 58;
			this.label2.Text = "Описание";
			// 
			// tb_Id
			// 
			this.tb_Id.Location = new System.Drawing.Point(702, 89);
			this.tb_Id.Name = "tb_Id";
			this.tb_Id.Size = new System.Drawing.Size(32, 20);
			this.tb_Id.TabIndex = 57;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(702, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 13);
			this.label1.TabIndex = 56;
			this.label1.Text = "Id";
			// 
			// dgv_Projects
			// 
			this.dgv_Projects.AllowUserToOrderColumns = true;
			this.dgv_Projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Projects.Location = new System.Drawing.Point(12, 57);
			this.dgv_Projects.Name = "dgv_Projects";
			this.dgv_Projects.Size = new System.Drawing.Size(652, 468);
			this.dgv_Projects.TabIndex = 52;
			this.dgv_Projects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Projects_CellClick);
			this.dgv_Projects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Projects_CellContentClick);
			// 
			// CustProjForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1073, 554);
			this.Controls.Add(this.cb_Customer);
			this.Controls.Add(this.cb_Worker);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.tb_Search);
			this.Controls.Add(this.btn_Refresh);
			this.Controls.Add(this.button4);
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
			this.Controls.Add(this.dgv_Projects);
			this.Name = "CustProjForm";
			this.Text = "CustProjForm";
			this.Load += new System.EventHandler(this.CustProjForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Projects)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cb_Customer;
		private System.Windows.Forms.ComboBox cb_Worker;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tb_Search;
		private System.Windows.Forms.Button btn_Refresh;
		private System.Windows.Forms.Button button4;
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
		private System.Windows.Forms.DataGridView dgv_Projects;
	}
}
namespace geo_dotnet.Forms.Admin
{
	partial class AddProjectDialogForm
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
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_Description = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_Save = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.cb_Worker = new System.Windows.Forms.ComboBox();
			this.cb_Customer = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(36, 18);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(152, 25);
			this.label7.TabIndex = 60;
			this.label7.Text = "Новый проект";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(171, 112);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 13);
			this.label6.TabIndex = 58;
			this.label6.Text = "Заказчик";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(171, 62);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 13);
			this.label5.TabIndex = 56;
			this.label5.Text = "Дата окончания";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(23, 62);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 13);
			this.label4.TabIndex = 54;
			this.label4.Text = "Дата начала";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 52;
			this.label3.Text = "Работник";
			// 
			// tb_Description
			// 
			this.tb_Description.Location = new System.Drawing.Point(23, 177);
			this.tb_Description.Multiline = true;
			this.tb_Description.Name = "tb_Description";
			this.tb_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tb_Description.Size = new System.Drawing.Size(305, 261);
			this.tb_Description.TabIndex = 51;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 161);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 50;
			this.label2.Text = "Описание";
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(23, 448);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(83, 30);
			this.btn_Save.TabIndex = 47;
			this.btn_Save.Text = "Сохранить";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(23, 78);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(139, 20);
			this.dateTimePicker1.TabIndex = 61;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(171, 78);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(139, 20);
			this.dateTimePicker2.TabIndex = 62;
			// 
			// cb_Worker
			// 
			this.cb_Worker.FormattingEnabled = true;
			this.cb_Worker.Location = new System.Drawing.Point(23, 128);
			this.cb_Worker.Name = "cb_Worker";
			this.cb_Worker.Size = new System.Drawing.Size(139, 21);
			this.cb_Worker.TabIndex = 63;
			// 
			// cb_Customer
			// 
			this.cb_Customer.FormattingEnabled = true;
			this.cb_Customer.Location = new System.Drawing.Point(171, 128);
			this.cb_Customer.Name = "cb_Customer";
			this.cb_Customer.Size = new System.Drawing.Size(139, 21);
			this.cb_Customer.TabIndex = 64;
			// 
			// AddProjectDialogForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(340, 490);
			this.Controls.Add(this.cb_Customer);
			this.Controls.Add(this.cb_Worker);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tb_Description);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn_Save);
			this.Name = "AddProjectDialogForm";
			this.Text = "AddProjectDialogForm";
			this.Load += new System.EventHandler(this.AddProjectDialogForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_Description;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.ComboBox cb_Worker;
		private System.Windows.Forms.ComboBox cb_Customer;
	}
}
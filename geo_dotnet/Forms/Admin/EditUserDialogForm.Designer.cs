namespace geo_dotnet.Forms.Admin
{
	partial class EditUserDialogForm
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
			this.tb_Password = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tb_Login = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_Fio = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.cb_Role = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// tb_Password
			// 
			this.tb_Password.Location = new System.Drawing.Point(157, 75);
			this.tb_Password.Name = "tb_Password";
			this.tb_Password.Size = new System.Drawing.Size(139, 20);
			this.tb_Password.TabIndex = 33;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(157, 59);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 13);
			this.label5.TabIndex = 32;
			this.label5.Text = "Пароль";
			// 
			// tb_Login
			// 
			this.tb_Login.Location = new System.Drawing.Point(12, 75);
			this.tb_Login.Name = "tb_Login";
			this.tb_Login.Size = new System.Drawing.Size(139, 20);
			this.tb_Login.TabIndex = 31;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 30;
			this.label4.Text = "Логин";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(314, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 28;
			this.label3.Text = "Роль";
			// 
			// tb_Fio
			// 
			this.tb_Fio.Location = new System.Drawing.Point(11, 123);
			this.tb_Fio.Name = "tb_Fio";
			this.tb_Fio.Size = new System.Drawing.Size(332, 20);
			this.tb_Fio.TabIndex = 27;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 13);
			this.label2.TabIndex = 26;
			this.label2.Text = "Фио";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(9, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(325, 25);
			this.label7.TabIndex = 36;
			this.label7.Text = "Добавить нового пользователя";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(11, 172);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(83, 30);
			this.button3.TabIndex = 37;
			this.button3.Text = "Сохранить";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// cb_Role
			// 
			this.cb_Role.FormattingEnabled = true;
			this.cb_Role.Location = new System.Drawing.Point(315, 74);
			this.cb_Role.Name = "cb_Role";
			this.cb_Role.Size = new System.Drawing.Size(121, 21);
			this.cb_Role.TabIndex = 38;
			// 
			// EditUserDialogForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(518, 214);
			this.Controls.Add(this.cb_Role);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.tb_Password);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tb_Login);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tb_Fio);
			this.Controls.Add(this.label2);
			this.Name = "EditUserDialogForm";
			this.Text = "EditUserDialogForm";
			this.Load += new System.EventHandler(this.EditUserDialogForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox tb_Password;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tb_Login;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_Fio;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ComboBox cb_Role;
	}
}
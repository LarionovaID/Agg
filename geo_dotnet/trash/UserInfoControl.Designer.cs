namespace geo_dotnet.Controls.Admin
{
	partial class UserInfoControl
	{
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.tb_Id = new System.Windows.Forms.TextBox();
			this.tb_Fio = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_Role = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_Login = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tb_Password = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tb_Phone = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btn_Save = new System.Windows.Forms.Button();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Id";
			// 
			// tb_Id
			// 
			this.tb_Id.Location = new System.Drawing.Point(13, 30);
			this.tb_Id.Name = "tb_Id";
			this.tb_Id.Size = new System.Drawing.Size(32, 20);
			this.tb_Id.TabIndex = 1;
			// 
			// tb_Fio
			// 
			this.tb_Fio.Location = new System.Drawing.Point(13, 76);
			this.tb_Fio.Name = "tb_Fio";
			this.tb_Fio.Size = new System.Drawing.Size(332, 20);
			this.tb_Fio.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Фио";
			// 
			// tb_Role
			// 
			this.tb_Role.Location = new System.Drawing.Point(363, 30);
			this.tb_Role.Name = "tb_Role";
			this.tb_Role.Size = new System.Drawing.Size(139, 20);
			this.tb_Role.TabIndex = 5;
			this.tb_Role.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(363, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Роль";
			// 
			// tb_Login
			// 
			this.tb_Login.Location = new System.Drawing.Point(61, 30);
			this.tb_Login.Name = "tb_Login";
			this.tb_Login.Size = new System.Drawing.Size(139, 20);
			this.tb_Login.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(61, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Логин";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// tb_Password
			// 
			this.tb_Password.Location = new System.Drawing.Point(206, 30);
			this.tb_Password.Name = "tb_Password";
			this.tb_Password.Size = new System.Drawing.Size(139, 20);
			this.tb_Password.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(206, 14);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Пароль";
			// 
			// tb_Phone
			// 
			this.tb_Phone.Location = new System.Drawing.Point(363, 76);
			this.tb_Phone.Name = "tb_Phone";
			this.tb_Phone.Size = new System.Drawing.Size(139, 20);
			this.tb_Phone.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(363, 60);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Телефон";
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(534, 32);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(86, 28);
			this.btn_Save.TabIndex = 12;
			this.btn_Save.Text = "Сохранить";
			this.btn_Save.UseVisualStyleBackColor = true;
			// 
			// btn_Delete
			// 
			this.btn_Delete.Location = new System.Drawing.Point(534, 66);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(86, 28);
			this.btn_Delete.TabIndex = 13;
			this.btn_Delete.Text = "Удалить";
			this.btn_Delete.UseVisualStyleBackColor = true;
			// 
			// UserInfoControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btn_Delete);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.tb_Phone);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tb_Password);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tb_Login);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tb_Role);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tb_Fio);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tb_Id);
			this.Controls.Add(this.label1);
			this.Name = "UserInfoControl";
			this.Size = new System.Drawing.Size(642, 115);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_Id;
		private System.Windows.Forms.TextBox tb_Fio;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_Role;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_Login;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tb_Password;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tb_Phone;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.Button btn_Delete;
	}
}

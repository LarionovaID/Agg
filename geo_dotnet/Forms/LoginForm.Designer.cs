namespace geo_dotnet
{
	partial class LoginForm
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

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.tb_Server = new System.Windows.Forms.TextBox();
			this.lb_Server = new System.Windows.Forms.Label();
			this.lb_dbName = new System.Windows.Forms.Label();
			this.tb_dbName = new System.Windows.Forms.TextBox();
			this.lb_Login = new System.Windows.Forms.Label();
			this.tb_Login = new System.Windows.Forms.TextBox();
			this.lb_Password = new System.Windows.Forms.Label();
			this.tb_Password = new System.Windows.Forms.TextBox();
			this.btn_Login = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tb_Server
			// 
			this.tb_Server.Location = new System.Drawing.Point(55, 65);
			this.tb_Server.Multiline = true;
			this.tb_Server.Name = "tb_Server";
			this.tb_Server.Size = new System.Drawing.Size(293, 29);
			this.tb_Server.TabIndex = 0;
			// 
			// lb_Server
			// 
			this.lb_Server.AutoSize = true;
			this.lb_Server.Location = new System.Drawing.Point(63, 49);
			this.lb_Server.Name = "lb_Server";
			this.lb_Server.Size = new System.Drawing.Size(102, 13);
			this.lb_Server.TabIndex = 1;
			this.lb_Server.Text = "Название сервера";
			// 
			// lb_dbName
			// 
			this.lb_dbName.AutoSize = true;
			this.lb_dbName.Location = new System.Drawing.Point(63, 103);
			this.lb_dbName.Name = "lb_dbName";
			this.lb_dbName.Size = new System.Drawing.Size(126, 13);
			this.lb_dbName.TabIndex = 3;
			this.lb_dbName.Text = "Название базы данных";
			// 
			// tb_dbName
			// 
			this.tb_dbName.Location = new System.Drawing.Point(55, 119);
			this.tb_dbName.Multiline = true;
			this.tb_dbName.Name = "tb_dbName";
			this.tb_dbName.Size = new System.Drawing.Size(293, 29);
			this.tb_dbName.TabIndex = 2;
			// 
			// lb_Login
			// 
			this.lb_Login.AutoSize = true;
			this.lb_Login.Location = new System.Drawing.Point(63, 171);
			this.lb_Login.Name = "lb_Login";
			this.lb_Login.Size = new System.Drawing.Size(38, 13);
			this.lb_Login.TabIndex = 5;
			this.lb_Login.Text = "Логин";
			// 
			// tb_Login
			// 
			this.tb_Login.Location = new System.Drawing.Point(55, 187);
			this.tb_Login.Multiline = true;
			this.tb_Login.Name = "tb_Login";
			this.tb_Login.Size = new System.Drawing.Size(293, 29);
			this.tb_Login.TabIndex = 4;
			// 
			// lb_Password
			// 
			this.lb_Password.AutoSize = true;
			this.lb_Password.Location = new System.Drawing.Point(63, 224);
			this.lb_Password.Name = "lb_Password";
			this.lb_Password.Size = new System.Drawing.Size(45, 13);
			this.lb_Password.TabIndex = 7;
			this.lb_Password.Text = "Пароль";
			// 
			// tb_Password
			// 
			this.tb_Password.Location = new System.Drawing.Point(55, 240);
			this.tb_Password.Multiline = true;
			this.tb_Password.Name = "tb_Password";
			this.tb_Password.Size = new System.Drawing.Size(293, 29);
			this.tb_Password.TabIndex = 6;
			// 
			// btn_Login
			// 
			this.btn_Login.Location = new System.Drawing.Point(155, 297);
			this.btn_Login.Name = "btn_Login";
			this.btn_Login.Size = new System.Drawing.Size(97, 31);
			this.btn_Login.TabIndex = 8;
			this.btn_Login.Text = "Подключиться";
			this.btn_Login.UseVisualStyleBackColor = true;
			this.btn_Login.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 364);
			this.Controls.Add(this.btn_Login);
			this.Controls.Add(this.lb_Password);
			this.Controls.Add(this.tb_Password);
			this.Controls.Add(this.lb_Login);
			this.Controls.Add(this.tb_Login);
			this.Controls.Add(this.lb_dbName);
			this.Controls.Add(this.tb_dbName);
			this.Controls.Add(this.lb_Server);
			this.Controls.Add(this.tb_Server);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tb_Server;
		private System.Windows.Forms.Label lb_Server;
		private System.Windows.Forms.Label lb_dbName;
		private System.Windows.Forms.TextBox tb_dbName;
		private System.Windows.Forms.Label lb_Login;
		private System.Windows.Forms.TextBox tb_Login;
		private System.Windows.Forms.Label lb_Password;
		private System.Windows.Forms.TextBox tb_Password;
		private System.Windows.Forms.Button btn_Login;
	}
}


namespace geo
{
	partial class LoginForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			tb_db = new TextBox();
			lbl_db = new Label();
			lbl_Login = new Label();
			tb_Login = new TextBox();
			lbl_Password = new Label();
			tb_Password = new TextBox();
			btn_Login = new Button();
			label1 = new Label();
			textBox1 = new TextBox();
			SuspendLayout();
			// 
			// tb_db
			// 
			tb_db.Location = new Point(245, 74);
			tb_db.Name = "tb_db";
			tb_db.Size = new Size(309, 23);
			tb_db.TabIndex = 0;
			// 
			// lbl_db
			// 
			lbl_db.AutoSize = true;
			lbl_db.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			lbl_db.Location = new Point(245, 50);
			lbl_db.Name = "lbl_db";
			lbl_db.Size = new Size(139, 21);
			lbl_db.TabIndex = 1;
			lbl_db.Text = "Название сервера";
			lbl_db.Click += lbl_db_Click;
			// 
			// lbl_Login
			// 
			lbl_Login.AutoSize = true;
			lbl_Login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			lbl_Login.Location = new Point(245, 195);
			lbl_Login.Name = "lbl_Login";
			lbl_Login.Size = new Size(54, 21);
			lbl_Login.TabIndex = 3;
			lbl_Login.Text = "Логин";
			// 
			// tb_Login
			// 
			tb_Login.Location = new Point(245, 219);
			tb_Login.Name = "tb_Login";
			tb_Login.Size = new Size(309, 23);
			tb_Login.TabIndex = 2;
			// 
			// lbl_Password
			// 
			lbl_Password.AutoSize = true;
			lbl_Password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			lbl_Password.Location = new Point(245, 270);
			lbl_Password.Name = "lbl_Password";
			lbl_Password.Size = new Size(63, 21);
			lbl_Password.TabIndex = 5;
			lbl_Password.Text = "Пароль";
			// 
			// tb_Password
			// 
			tb_Password.Location = new Point(245, 294);
			tb_Password.Name = "tb_Password";
			tb_Password.Size = new Size(309, 23);
			tb_Password.TabIndex = 4;
			// 
			// btn_Login
			// 
			btn_Login.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			btn_Login.Location = new Point(351, 366);
			btn_Login.Name = "btn_Login";
			btn_Login.Size = new Size(106, 39);
			btn_Login.TabIndex = 6;
			btn_Login.Text = "Войти";
			btn_Login.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label1.Location = new Point(245, 125);
			label1.Name = "label1";
			label1.Size = new Size(174, 21);
			label1.TabIndex = 8;
			label1.Text = "Название базы данных";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(245, 149);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(309, 23);
			textBox1.TabIndex = 7;
			// 
			// LoginForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label1);
			Controls.Add(textBox1);
			Controls.Add(btn_Login);
			Controls.Add(lbl_Password);
			Controls.Add(tb_Password);
			Controls.Add(lbl_Login);
			Controls.Add(tb_Login);
			Controls.Add(lbl_db);
			Controls.Add(tb_db);
			Name = "LoginForm";
			Text = "Авторизация";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox tb_db;
		private Label lbl_db;
		private Label lbl_Login;
		private TextBox tb_Login;
		private Label lbl_Password;
		private TextBox tb_Password;
		private Button btn_Login;
		private Label label1;
		private TextBox textBox1;
	}
}

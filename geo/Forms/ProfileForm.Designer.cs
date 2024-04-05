namespace geo.Forms
{
	partial class ProfileForm
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
			header1 = new Controls.Header();
			label1 = new Label();
			textBox1 = new TextBox();
			label2 = new Label();
			label3 = new Label();
			textBox2 = new TextBox();
			label4 = new Label();
			textBox3 = new TextBox();
			label5 = new Label();
			textBox4 = new TextBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// header1
			// 
			header1.BackColor = Color.DarkSlateGray;
			header1.Location = new Point(0, 0);
			header1.Name = "header1";
			header1.Size = new Size(800, 61);
			header1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label1.Location = new Point(302, 79);
			label1.Name = "label1";
			label1.Size = new Size(259, 32);
			label1.TabIndex = 1;
			label1.Text = "Данные пользователя";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(267, 136);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(330, 36);
			textBox1.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label2.Location = new Point(207, 147);
			label2.Name = "label2";
			label2.Size = new Size(54, 25);
			label2.TabIndex = 3;
			label2.Text = "ФИО";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label3.Location = new Point(196, 209);
			label3.Name = "label3";
			label3.Size = new Size(65, 25);
			label3.TabIndex = 5;
			label3.Text = "Логин";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(267, 198);
			textBox2.Multiline = true;
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(330, 36);
			textBox2.TabIndex = 4;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label4.Location = new Point(183, 272);
			label4.Name = "label4";
			label4.Size = new Size(78, 25);
			label4.TabIndex = 7;
			label4.Text = "Пароль";
			// 
			// textBox3
			// 
			textBox3.Location = new Point(267, 261);
			textBox3.Multiline = true;
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(330, 36);
			textBox3.TabIndex = 6;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label5.Location = new Point(174, 336);
			label5.Name = "label5";
			label5.Size = new Size(87, 25);
			label5.TabIndex = 9;
			label5.Text = "Телефон";
			// 
			// textBox4
			// 
			textBox4.Location = new Point(267, 325);
			textBox4.Multiline = true;
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(330, 36);
			textBox4.TabIndex = 8;
			// 
			// button1
			// 
			button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			button1.Location = new Point(267, 393);
			button1.Name = "button1";
			button1.Size = new Size(131, 35);
			button1.TabIndex = 10;
			button1.Text = "Редактировать";
			button1.UseVisualStyleBackColor = true;
			// 
			// ProfileForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button1);
			Controls.Add(label5);
			Controls.Add(textBox4);
			Controls.Add(label4);
			Controls.Add(textBox3);
			Controls.Add(label3);
			Controls.Add(textBox2);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Controls.Add(header1);
			Name = "ProfileForm";
			Text = "ProfileForm";
			Load += ProfileForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Controls.Header header1;
		private Label label1;
		private TextBox textBox1;
		private Label label2;
		private Label label3;
		private TextBox textBox2;
		private Label label4;
		private TextBox textBox3;
		private Label label5;
		private TextBox textBox4;
		private Button button1;
	}
}